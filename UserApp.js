var exp=require("express");
var sql=require("mysql2");

var app=exp();
app.use(exp.static('files'));
app.listen(9000,function(){console.log("Server Hosted")});

var con=sql.createConnection({
	host:"localhost",
	user:"root",
	password:"root",
	database:"users"
});

con.connect(function(err){
	if(!err){
		console.log("Connected to Db");
	}
});

app.get("/form",function(req,res){
	res.sendFile(__dirname+"/UserForm.html");
});

app.get("/req",function(req,res){
	con.query("select username from user where username !="+req.query.frm,function(err,result){
		if(!err){
			
			res.send(JSON.stringify(result));
		}
		else{
			console.log("error");
		}
	});
});
app.all("*",function(req,res){
	res.send("Invalid URL!!");
});
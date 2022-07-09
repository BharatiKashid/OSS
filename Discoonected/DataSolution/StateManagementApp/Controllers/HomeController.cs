using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementApp.Controllers
{
    public class HomeController : Controller
    {

        string companyName = "Transflower";

        // GET: Home

        public HomeController()
        {

        }
        public ActionResult Index()
        {
            //viewBag is used to send data from action method to View
           // companyName = "KnowIT"
            companyName = this.HttpContext.Application["company"].ToString();


            ViewBag.CompanyName = companyName;

            return View();
        }

        public ActionResult Aboutus()
        {
            ViewBag.CompanyName = this.HttpContext.Application["company"].ToString();
            return View();
        }
        public ActionResult Contact()
        {

            ViewBag.CompanyName = this.HttpContext.Application["company"].ToString();
            return View();
        }
        public ActionResult Services()
        {  
            ViewBag.CompanyName = this.HttpContext.Application["company"].ToString();
            return View();
        }


        public ActionResult Update()
        {
            ViewBag.CompanyName = this.HttpContext.Application["company"].ToString();
            return View();
        }

        [HttpPost]
        public ActionResult Update(string companyname)
        {
          this.HttpContext.Application["company"]=companyname;
          return RedirectToAction("Index");
        }
    }
}
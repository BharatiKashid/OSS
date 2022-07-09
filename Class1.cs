using System;
using System.Collections.Generic;

namespace Airthmetic
{


	public class Class1
	{
		

		public int num1 { get; set; }

		public int num2 { get; set; }

		int add;
		int mul;

		public Class1()
		{
			num1 = 20;
			num2 = 5;

		}
		public Class1(int a, int b)
		{
			this.num1 = a;
			this.num2 = b;
		}

		public void Addition(int a, int b)
		{
			add = a + b;
			Console.WriteLine("Addition of two numbers :" + add);
			Console.WriteLine("**************************");
		}

		public void Multiplocation(int s, int y)
		{
			mul = s * b;
			Console.WriteLine("Multiplication of two numbers :" + mul);
			Console.WriteLine("**************************");

		}
		public void division(int s, int y)
		{
			int div = s / b;
			Console.WriteLine("Multiplication of two numbers :" + div);
			Console.WriteLine("**************************");

		}

		static void main(string[] args)
		{
			Class1 c = new Class1();
			c.Addition();
			c.Multiplocation();
			c.division();
			//	c.Addition(40, 10);

			Class1 c1 = new Class1(40, 10)
				c1.Addition();
			c1.Multiplocation();
			c1.division();
		}
	
    }
}

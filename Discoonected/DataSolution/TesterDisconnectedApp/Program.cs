using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
using DAL;

namespace TesterDisconnectedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = EmployeeDALDisConnected.GetAll();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + "  " + emp.Designation + "  " + emp.Salary);
            }

            Console.WriteLine("Retrieving single record based on GetByID");
            Employee employee = EmployeeDALDisConnected.GetById(99);
            Console.WriteLine(employee.Name + "  " + employee.Designation + "  " + employee.Salary);

            Employee newEmployee = new Employee { ID = 13, Name = "Simran Kapoor", Designation = "CTO", Salary = 150000 };
            bool status = EmployeeDALDisConnected.Insert(newEmployee);
            Console.WriteLine("Insertion status="+status);

            status = EmployeeDALDisConnected.Delete(16);
            Console.WriteLine("Deletion status=" + status);
            Console.WriteLine("\n \n \n \n After Data Manipulation data data base using disconnected Data Access...");

            employees = EmployeeDALDisConnected.GetAll();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + "  " + emp.Designation + "  " + emp.Salary);
            }
            Console.ReadLine();
        }
    }
}

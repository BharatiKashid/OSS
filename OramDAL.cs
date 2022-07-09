
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> employees = HRManager.GetAll();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            Employee employee = HRManager.GetByID(id);
            return View(employee);
        }
        public ActionResult Delete(int id)
        {
            bool status = HRManager.Delete(id);
            return RedirectToAction("index");
        }

        public ActionResult Insert(Employee emp)
        {
            return View(emp);
        }

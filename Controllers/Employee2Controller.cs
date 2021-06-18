using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
namespace WebApplication2.Controllers
{
    public class Employee2Controller : Controller
    {
        // GET: Employee2
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
    }
}
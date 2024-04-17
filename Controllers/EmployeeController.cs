using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employeelist = new List<Employee>()
            {
            new Employee() {
                EmployeeId = 11,
                FirstName = "fatma",
                LastName = "G",
                Email = "fatma@gmail.com"
            },
            new Employee() {
                EmployeeId = 22,
                FirstName = "Awdah",
                LastName = "A",
                Email = "Awdah@gmail.com"
            } };

            return View(employeelist.ToList());




        }
        public IActionResult Details(int id) {
            List<Employee> employeelist = new List<Employee>()
            {
            new Employee() {
                EmployeeId = 11,
                FirstName = "fatma",
                LastName = "G",
                Email = "fatma@gmail.com"
            },
            new Employee() {
                EmployeeId = 22,
                FirstName = "Awdah",
                LastName = "A",
                Email = "Awdah@gmail.com"
            } };
            var employee = employeelist.SingleOrDefault(a => a.EmployeeId == id);
            if (employee == null)
            {
                return RedirectToAction("Index");


            }
            return View(employee);




        }
    }
    }
    


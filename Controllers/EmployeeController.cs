using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        //List<Employee> employeelist = new List<Employee>()
        //{
        //new Employee() {
        //    EmployeeId = 11,
        //    FirstName = "fatma",
        //    LastName = "G",
        //    Email = "fatma@gmail.com"
        //},
        //new Employee() {
        //    EmployeeId = 22,
        //    FirstName = "Awdah",
        //    LastName = "A",
        //    Email = "Awdah@gmail.com"
        //} };

        //return View(employeelist.ToList());
        private static List<Employee> employeeList = new List<Employee>() {
           new Employee { FirstName = "Bader", EmployeeId = 2992, Email = "BA@gmail.com" },
            new Employee { FirstName = "Abdulah", EmployeeId = 2537, Email = "Abd@gmail.com" },
            new Employee { FirstName = "Munira", EmployeeId = 7392, Email = "Manh@gmail.com" },


            };


        public IActionResult Index()
        {

            return View(employeeList);
        }
        public IActionResult Details(int id)
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
            var employee = employeelist.SingleOrDefault(a => a.EmployeeId == id);
            if (employee == null)
            {
                return RedirectToAction("Index");


            }
            return View(employee);




        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AddEmployeeform form)
        {

            var name = form.Name;
            var email = form.Email;
            var civilId = form.CivilID;
            var salary = form.Salary;
            var deparementName = form.DepartmentName;
            var isManger = form.IsManger;


            employeeList.Add(new Employee { FirstName = name, Email = email, EmployeeId = 10 });

            {
                return View(Index);
            }
        }
    }
}

    

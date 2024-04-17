using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    { public IActionResult Index()
        {
            Customer[] customers = new Customer[] {
            new Customer { 
                Id = 11,
                Name = "fatma", 
                Address = "Kuwait city", 
                Email = "fatma@gmail.com" },

                new Customer{ 
                     Id = 22,
                     Name = "razan", 
                     Address = "Kuwait city", 
                     Email = "razan@gmail.com" },

                new Customer{
                     Id = 33,
                     Name = "awdah",
                     Address = "Kuwait city",
                     Email = "awdah@gmail.com" }
            } ;

            return View(customers.ToList());

        }

        public IActionResult Privacy()
        {
                return View();
        }



    }
}

using HRApplicationArApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApplicationArApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            Console.WriteLine(employee);
            return View();
        }
    }
}
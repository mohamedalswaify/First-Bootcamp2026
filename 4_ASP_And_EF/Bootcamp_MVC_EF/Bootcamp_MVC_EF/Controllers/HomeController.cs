using System.Diagnostics;
using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }





        public ActionResult GetHello()
        {
            return Content("Hello, World!");
        }


        public ActionResult GetUsers()
        {
            IList<string> users = new List<string> { "Alice, Bob", "Charlie" };

            return Ok(users);
        }

        public ActionResult GetEmployees()
        {
            IList<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Position = "Developer", Salary = 60000 },
                new Employee { Id = 2, Name = "Bob", Position = "Manager", Salary = 80000 },
                new Employee { Id = 3, Name = "Charlie", Position = "Tester", Salary = 50000 }
            };

            return Ok(employees );
        }

        public ActionResult GetEmployeesFront()
        {
            IList<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Position = "Developer", Salary = 60000 },
                new Employee { Id = 2, Name = "Bob", Position = "Manager", Salary = 80000 },
                new Employee { Id = 3, Name = "Charlie", Position = "Tester", Salary = 50000 }
            };

            return View(employees);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

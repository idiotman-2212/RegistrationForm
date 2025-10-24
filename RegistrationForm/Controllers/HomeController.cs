using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string Hello()
        {
            return "Hello";
        }

        public ViewResult MyView()
        {
            return View("myView");
        }

        public ViewResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }
        }

        public IActionResult StudentList()
        {
            var students = Repository.GetStudents();
            return View(students);
        }
    }
}

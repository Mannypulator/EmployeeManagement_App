using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var employees = _employeeRepository.GetEmployees();
            return View(employees);
        }
    
        public IActionResult Details(int id)
        {
            var homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details",
            };
          

            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var emp = _employeeRepository.AddEmployee(employee);
            return RedirectToAction("details", new { id = emp.Id});
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
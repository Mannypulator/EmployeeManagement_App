using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagement.Controllers
{
    // [Route("Home")]
    [Route("[controllers]")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("")]
        // [Route("Home")]
        // [Route("Home/Index")]
        [Route("~/")]
        // [Route("Index")]
        [Route("[action]")]
        public ViewResult Index()
        {
            var employees = _employeeRepository.GetEmployees();
            return View(employees);
        }
        [Route("Home/Detail/{id?}")]
        // [Route("Detail/{id?}")]
        [Route("[action]/{id?}")]
        public ViewResult Detail(int? id)
        {
            var homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details",
            };
          

            return View(homeDetailsViewModel);
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
using System.Diagnostics;
using FinalProject.ASP.NETcoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.ASP.NETcoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly EmployeeDBContext _context;

        private readonly QuarterlySalesDB _sales;

        private static Employee Lasha = new Employee
        {
            Id = 1,
            FirstName = "Lasha",
            LastName = "Mermanishvili",
            BirthDate = new DateTime(1998, 06, 16),
            HireDate = new DateTime(2016, 1, 8),
            Manager = 0
        };

        private QuarterlySales sale = new QuarterlySales
        {
            Employee = Lasha.FirstName,
            Amount = 3000,
            Year = 2015,
            Quarter = 1
        };
       
        public HomeController(ILogger<HomeController> logger, EmployeeDBContext context,
            QuarterlySalesDB sales)
        {
            _logger = logger;
            _context = context;
            _sales = sales;
        }

        public IActionResult Index()
        {
            var Employees = _context.Employees.ToList();
            var QuarterlySales = _sales.sales.ToList();
            QuarterlySales.Add(sale);
            Employees.Add(Lasha);



            return View(QuarterlySales);
        }
       
        [HttpGet]
        public IActionResult AddSales()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddSalesForm(QuarterlySales model)
        {
            if (ModelState.IsValid)
            {
                _sales.sales.Add(model);
                _sales.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddSales");
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployeeForm(Employee model)
        {

            if (ModelState.IsValid)
            {
                _context.Employees.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("AddEmployee");
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

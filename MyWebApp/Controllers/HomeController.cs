using Microsoft.AspNetCore.Mvc;

namespace MyWebApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["columnNames"] = new string[] { "ID", "Name", "Price", "Description", "Weight" };
            ViewData["content"] = new string[,]
            {
                {"101", "Apple", "1.01", "Apple", "1.01"},
                {"202", "Back", "2.02", "Apple", "1.01"},
                {"303", "Cup", "3.03", "Apple", "1.01"},
                {"404", "Donut", "3.03", "Apple", "1.01"}
            };
            return View();
        }

        public IActionResult Home() => View();
        public IActionResult Page1() => View();
        public IActionResult Page2() => View();
    }
} 
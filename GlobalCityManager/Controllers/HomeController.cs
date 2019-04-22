using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;

namespace GlobalCityManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly worldContext _db;
        public HomeController(worldContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dbcontext = _db;
            var cities = dbcontext.City.ToList();
            return View(cities);
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;

namespace GlobalCityManager.Controllers
{
    public class CountryController : Controller
    {
        private readonly worldContext _db;
        public CountryController(worldContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dbcontext = _db;
            var countries = dbcontext.Country.ToList();
            return View(countries);
        }

        public IActionResult Detail(string code)
        {
            var dbcontext = _db;
            var country = dbcontext.Country.FirstOrDefault(c => c.Code == code);
            if (country != null)
                return View("Detail", country);
            else
                return RedirectToAction("Index");
        }

    }
}
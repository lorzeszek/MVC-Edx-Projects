using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;

namespace GlobalCityManager.Controllers
{
    [Route("country")]
    public class CountryController : Controller
    {
        private readonly worldContext _db;
        public CountryController(worldContext db)
        {
            _db = db;
        }
        [Route("showall")]
        [HttpGet]
        public IActionResult ShowAll()
        {
            var dbcontext = _db;
            var countries = dbcontext.Country.ToList();
            return View(countries);
        }

        [Route("details")]
        [HttpGet]
        public IActionResult Detail(string code)
        {
            var dbcontext = _db;
            var country = dbcontext.Country.FirstOrDefault(c => c.Code == code);
            if (country != null)
                return View("Detail", country);
            else
                return RedirectToAction("Index");
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            var continentlist = (from country in _db.Country select country.Continent).ToList();
            continentlist.Insert(0, "Select");
            ViewBag.ListOfContinents = continentlist;
            var regionlist = (from country in _db.Country select country.Region).ToList();
            regionlist.Insert(0, "Select");
            ViewBag.ListOfRegions = regionlist;
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _db.Country.Add(country);
                _db.Country.SaveChanges();
            }
            return RedirectToAction("ShowAll");
        }

    }
}
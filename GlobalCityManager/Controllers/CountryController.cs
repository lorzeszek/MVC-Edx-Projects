using System.Linq;
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
            var continentlist = (from country in _db.Country select country.Continent).Distinct().ToList();
            continentlist.Insert(0, "Select...");
            ViewBag.ListOfContinents = continentlist;
            var regionlist = (from country in _db.Country select country.Region).Distinct().ToList();
            regionlist.Insert(0, "Select...");
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
                _db.SaveChanges();
            }
            return RedirectToAction("ShowAll");
        }
    }
}
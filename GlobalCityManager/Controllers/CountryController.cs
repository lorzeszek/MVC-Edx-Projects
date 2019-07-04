using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;
using System.Threading.Tasks;

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

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            var continentlist = _db.Country.Select(c => c.Continent).Distinct().ToList();
            continentlist.Insert(0, "Select...");
            ViewBag.ListOfContinents = continentlist;

            var regionlist = _db.Country.Select(c => c.Region).Distinct().ToList();
            regionlist.Insert(0, "Select...");
            ViewBag.ListOfRegions = regionlist;

            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _db.Country.Add(country);
                _db.SaveChanges();
                return RedirectToAction("Detail", country);
            }
            
            var continentlist = _db.Country.Select(c => c.Continent).Distinct().ToList();
            continentlist.Insert(0, "Select...");
            ViewBag.ListOfContinents = continentlist;

            var regionlist = _db.Country.Select(c => c.Region).Distinct().ToList();
            regionlist.Insert(0, "Select...");
            ViewBag.ListOfRegions = regionlist;

            return View();
        }
    }
}
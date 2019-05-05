using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;

namespace GlobalCityManager.Controllers
{
    [Route("city")]
    public class CityController : Controller
    {
        private readonly worldContext _db;
        public CityController(worldContext db)
        {
            _db = db;
        }

        [Route("showall")]
        [HttpGet]
        public IActionResult ShowAll()
        {
            var dbcontext = _db;
            var cities = dbcontext.City.ToList();
            return View(cities);
        }
    }
}


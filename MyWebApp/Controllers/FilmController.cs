using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers {
    public class FilmController : Controller 
    {
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Film film) 
        {
            if (this.ModelState.IsValid) {
                // create a new film ...
                return View("Created");
            } else {
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult Update(Film film) 
        {
            if (this.ModelState.IsValid) {
                // create a new film ...
                return View("Updated");
            } else {
                return View("Error");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Model;

namespace TestApp.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("main")]
        public IActionResult Main()
        {
            return View();
        }

        [HttpGet]
        [Route("getlist")]
        public IActionResult GetList()
        {
            var coffeelist = new List<Coffee>()
            {
                new Coffee { Id = 1, Name = "Americano" },
                new Coffee { Id = 2, Name = "Espresso" },
                new Coffee { Id = 3, Name = "Latte" },
            };
            return View(coffeelist);
        }

        [HttpPost]
        [Route("form")] 
        public IActionResult Form(Coffee coffee)
        {
            if (ModelState.IsValid)
            {
                return new JsonResult(coffee);
            }
            return View();
        }

        [HttpGet]
        [Route("form")]
        public IActionResult Form()
        {
            return View();
        }
    }
}
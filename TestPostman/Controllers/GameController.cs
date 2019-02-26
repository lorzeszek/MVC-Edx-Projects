using System;
using Microsoft.AspNetCore.Mvc;
using TestPostman.Models;

namespace TestPostman.Controllers
{
    public class GameController : Controller
    {
        [HttpPost]
        public IActionResult Create([ModelBinder(BinderType = typeof(GameModelBinder))]Game game) 
        {
            if (ModelState.IsValid == true) 
            {
                return View("Created", game);
            } 
            else 
            {
                throw new Exception("");
            }
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
    }
}
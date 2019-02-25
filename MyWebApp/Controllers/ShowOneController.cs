using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers 
{
    public class ShowOneController : Controller 
    {
        public IActionResult ShowOne() 
        {
        ViewBag.Title = "Show One Product Title";
        ViewBag.Header = "1st Product Header";
        ViewBag.product = new Product{ ID = 22, Name = "blabla bla", Price = 50.22};
        return View();
        }
    }
}
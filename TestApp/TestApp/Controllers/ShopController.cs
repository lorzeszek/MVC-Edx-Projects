using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Data;
using TestApp.Model;

namespace TestApp.Controllers
{
    [Route("shop")]
    public class ShopController : ControllerBase
    {
        public static List<Cocktail> cocktails = new List<Cocktail>();
        public static List<Coffee> coffees = new List<Coffee>();
        public static List<Sandwich> sandwiches = new List<Sandwich>();

        [HttpGet]
        [Route("{product}/{id}")]
        public IActionResult GetProduct(string product, int id)
        {
            if (product == "coffee")
            {
                if (coffees.Count >= id - 1)
                {
                    return new JsonResult(coffees[id]);
                }                
            }
            return NotFound();
        }

        [HttpPost]
        [Route("coffee")]
        public IActionResult AddCoffee([FromBody]Coffee coffee)
        {
            coffees.Add(coffee);
            return Ok();
        }








        //[Route("sandwitch/{id}/")]
        //public ActionResult<string> GetSandwitch(int id)
        //{
        //    return ShopData.sandwitches[id];
        //}

        //[Route("coctail/{id}/")]
        //public ActionResult<string> GetCoctail(int id)
        //{
        //    return ShopData.coctails[id];
        //}

        //[Route("coffee/{id}/")]
        //public ActionResult<string> GetCoffee(int id)
        //{
        //    return ShopData.coffees[1];
        //}

        //[Route("coffee/{id}/")]
        //[HttpPut]
        //public ActionResult<string> UpdateCoffee([FromQuery]int id, [FromForm]string coffeename)
        //{
        //    ShopData.coffees[id] = coffeename;
        //    return ShopData.coffees[id];
        //}

        //[Route("coffee/{id}/")]
        //[HttpPost]
        //public ActionResult<string> AddCoffee([FromForm]string coffeename)
        //{
        //    var dictionaryindex = ShopData.coffees.Last().Key + 1;
        //    ShopData.coffees.Add(dictionaryindex, coffeename);
        //    return ShopData.coffees[dictionaryindex];
        //}
    }
}
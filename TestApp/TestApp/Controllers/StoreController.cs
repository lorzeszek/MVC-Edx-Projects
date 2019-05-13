using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Route("store")]
    public class StoreController : ControllerBase  //nie zwraca widoku z 'Base'
    {
        //public IActionResult GetProductData()  //zwracac moze rożne typy
        //{
        //    return ;
        //}
        [Route("data")]   // sciezka bedzie: store/data
        public ActionResult<string> GetProductDataGeneric(string productName)  //zwraca tylko string i nic wiecej
        {
            return "get";
        }

        [Route("data/{id}/{name}/get")]   // sciezka bedzie: store/data
        public ActionResult<string> GetProductDataGeneric(string id, string name)  // w przegladarce: https://localhost:44321/store/data/123/ted/get
        {
            return id + " " + name + " IsString";
        }

        [Route("data/{id:int}/{name}/get")]   // sciezka bedzie: store/data
        public ActionResult<string> GetProductDataGenericTypeRecognition(int id, string name)  // w przegladarce: https://localhost:44321/store/data/123/ted/get rozpozna jak int
        {
            return "IsInt";
        }

        [Route("data")] // sciezka bedzie: store/data
        [HttpPost] //dla Postmana
        public ActionResult<string> TestMethod(string productName)  //zwraca tylko string i nic wiecej
        {
            return "post";
        }

        [Route("data")] // sciezka bedzie: store/data
        [HttpPut] //dla Postmana
        public ActionResult<string> TestMethodPut([FromQuery]string test, [FromForm]string data)  //zwraca tylko string i nic wiecej
        {
            return "put";
        }
    }
}
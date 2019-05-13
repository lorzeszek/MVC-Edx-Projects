using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Authorize]
    [Route("secure")]
    public class SecureController : Controller
    {
        //[AllowAnonymous]
        [HttpGet]
        [Route("test")]
        public ActionResult<string> Test()
        {
            return "test";
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace TimeDisplay.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // This is how we would do this stuff on the server.
            // DateTime RightNow = DateTime.Now;
            // string Date = RightNow.ToString("MMM dd, yyyy");
            // string Time = DateTime.Now.ToString("h:mm:ss tt");
            // ViewBag.TheTime = Time;
            // ViewBag.TheDate = Date;
            return View();
        }
    }
}

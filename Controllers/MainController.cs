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
            // DateTime RightNow = DateTime.Now;
            // string Date = RightNow.ToString("MMM dd, yyyy");
            // string Time = RightNow.ToString("HH:MM tt");
            // Console.WriteLine(Date);
            // Console.WriteLine(Time);
            // ViewBag.TheTime = Time;
            // ViewBag.TheDate = Date;
            return View();
        }
    }
}

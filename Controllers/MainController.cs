using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

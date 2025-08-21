namespace myMvc.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Chao";

            return View();
        }
    }
}
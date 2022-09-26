using Microsoft.AspNetCore.Mvc;

namespace mvp_app.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using mvp_app.Models;

namespace mvp_app.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}

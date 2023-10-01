using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class RegistrationsController : Controller
    {
        public IActionResult Registrations()
        {
            return View("Registrations");
        }
    }
}

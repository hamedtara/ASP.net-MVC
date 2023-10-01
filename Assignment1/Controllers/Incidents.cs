using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class IncidentsController : Controller
    {
        public IActionResult Incidents()
        {
            return View("Incidents");
        }
    }
}

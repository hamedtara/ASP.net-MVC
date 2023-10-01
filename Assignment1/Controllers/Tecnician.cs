using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class TecnicianController : Controller
    {
        public IActionResult Tecnician()
        {
            return View("Tecnician");
        }
    }
}

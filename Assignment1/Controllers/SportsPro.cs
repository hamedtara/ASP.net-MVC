using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class SportsProController : Controller
    {
        public IActionResult SportsPro()
        {
            return View("SportsPro");
        }
    }
}

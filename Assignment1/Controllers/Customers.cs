using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Customers()
        {
            return View("Customers");
        }
    }
}

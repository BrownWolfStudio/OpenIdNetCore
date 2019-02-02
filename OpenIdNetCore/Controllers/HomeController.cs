using Microsoft.AspNetCore.Mvc;

namespace OpenIdNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content(nameof(Index));
        }

        public IActionResult Error()
        {
            return Content(nameof(Error));
        }
    }
}

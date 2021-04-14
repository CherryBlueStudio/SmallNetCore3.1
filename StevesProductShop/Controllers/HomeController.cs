using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StevesProductShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

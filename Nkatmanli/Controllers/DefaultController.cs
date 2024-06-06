using Microsoft.AspNetCore.Mvc;

namespace Nkatmanli.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

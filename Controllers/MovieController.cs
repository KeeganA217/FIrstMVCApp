using Microsoft.AspNetCore.Mvc;

namespace FIrstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

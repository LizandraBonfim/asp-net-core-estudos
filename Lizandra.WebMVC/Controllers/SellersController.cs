using Microsoft.AspNetCore.Mvc;

namespace Lizandra.WebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
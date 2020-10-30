using Microsoft.AspNetCore.Mvc;

namespace Lizandra.WebMVC.Controllers
{
    public class SalesRecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
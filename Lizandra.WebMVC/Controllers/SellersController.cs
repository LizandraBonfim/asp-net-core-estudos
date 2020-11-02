using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lizandra.WebMVC.Models;
using Lizandra.WebMVC.Services;
using Lizandra.WebMVC.Models.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace Lizandra.WebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var department = _departmentService.FindAll();
            var viewModels = new SellerFormViewModel{Departments = department};
            return View(viewModels);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        
        
    }
}
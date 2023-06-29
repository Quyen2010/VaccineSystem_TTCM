using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VaccineSystem.Data;
using VaccineSystem.Models;

namespace VaccineSystem.Controllers
{
    public class HomeController : Controller
    {
		private readonly VaccineSystemContext _context;
		public HomeController(VaccineSystemContext context)
        {
			_context = context;
		}
        public IActionResult Index()
        {
			var _product = _context.Product.Include(p => p.Brand).Include(p => p.Category);
			return View(_product.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//using Microsoft.AspNetCore.Mvc;
//using VaccineSystem.Data;
//using VaccineSystem.Infrastructure;
//using VaccineSystem.Models;

//namespace VaccineSystem.Controllers
//{
//	public class CartController : Controller
//	{
//		public Cart? Cart { get; set; }
//		private readonly VaccineSystemContext _context;
//		public CartController(VaccineSystemContext context)
//		{
//			_context = context;
//		}
//		public IActionResult AddToCart(int productId)
//		{
//			Product? product = _context.Product.FirstOrDefault(p => p.ProductId = productId);
//			if(product != null)
//			{
//				Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
//				Cart.AddItem(product, 1);
//				HttpContext.Session.SetJson("Cart", Cart);
//			}
//			return View("Cart");
//		}
//	}
//}

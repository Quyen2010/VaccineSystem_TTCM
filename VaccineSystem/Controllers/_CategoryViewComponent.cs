using Microsoft.AspNetCore.Mvc;
using VaccineSystem.Data;

namespace VaccineSystem.Controllers
{
	[ViewComponent(Name ="_Category")]
	public class _CategoryViewComponent:ViewComponent
	{
		private readonly VaccineSystemContext _context;

		public _CategoryViewComponent(VaccineSystemContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _category = _context.Category.ToList();
			return View("_Category", _category);
		}
	}
}

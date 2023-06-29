using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using VaccineSystem.Data;

namespace VaccineSystem.Controllers
{
	[ViewComponent(Name = "_CategorySide")]
	public class _CategorySideViewComponent : ViewComponent
	{
		private readonly VaccineSystemContext _context;

		public _CategorySideViewComponent(VaccineSystemContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var _category = _context.Category.ToList();
			return View("_CategorySide", _category);
		}
	}
}

using Appp.Data;
using Microsoft.AspNetCore.Mvc;

namespace Appp.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CategoryController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var	categories = _context.categories.ToList();
			return View(categories);
		}

		public IActionResult Details(int id) 
		{
			var category = _context.categories.Find(id);

			if(category == null)
			{
				return NotFound();
			}

			return View(category);
		
		}
	}
}

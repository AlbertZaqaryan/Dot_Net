using Appp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appp.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ProductController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var product = _context.products.Include(p => p.Category).ToList();

			if (product == null) 
			{
				return NotFound();
			
			}
			return View(product);
		}

		public IActionResult Details(int id) 
		{
			var product = _context.products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);

			if(product == null)
			{
				return NotFound();
			}
			return View(product);
		}
	}
}

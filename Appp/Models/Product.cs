using System.ComponentModel.DataAnnotations;

namespace Appp.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}

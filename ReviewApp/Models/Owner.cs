using System;
namespace ReviewApp.Models
{
	public class Owner
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public ICollection<Car>? Cars { get; set; }
	}
}


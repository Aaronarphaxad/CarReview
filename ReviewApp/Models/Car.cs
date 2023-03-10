using System;
namespace ReviewApp.Models
{
	public class Car
	{
		public Guid Id { get; set; }
		public string? Brand { get; set; }
		public string? Model { get; set; }
		public int Year { get; set; }
		public string? Color { get; set; }
        public string? Country { get; set; }
        public string? Mileage { get; set; }
		public int Price { get; set; }
		public int Rating { get; set; }
		//public ICollection<Review>? Reviews { get; set; }


        public Car()
        {
            Id = Guid.NewGuid();
        }

    } 
}

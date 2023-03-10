using System;
using ReviewApp.Models;
using System.Diagnostics;

namespace ReviewApp
{
	public class Seed
	{
        public static async Task SeedData(DataContext context)
        {
            if (context.Cars.Any()) return;

            var cars = new List<Car>
            {
                new Car
                {
                    Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                   Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                     Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                   Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                   Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                    Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                    Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                   Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                    Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                },
                new Car
                {
                    Brand = "Nissan",
                    Model = "Car 2 months ago",
                    Year = 2007,
                    Color = "London",
                    Country = "Pub",
                    Mileage = "100",
                    Price = 6000,
                    Rating = 3
                }
            };

            await context.Cars.AddRangeAsync(cars);
            await context.SaveChangesAsync();
        }
    }
}


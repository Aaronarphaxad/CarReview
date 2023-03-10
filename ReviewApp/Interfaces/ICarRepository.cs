using System;
using ReviewApp.Data.Dto;
using ReviewApp.Models;

namespace ReviewApp.Interfaces
{
	public interface ICarRepository
	{
		ICollection<Car> GetCars();

		Car GetCarById(Guid id);

		Car GetCarByBrand(string brand);

		bool CarExists(Guid carId);

        bool CarExists(string brand);

		bool CreateCar(Car car);

		bool Save();
    }
}


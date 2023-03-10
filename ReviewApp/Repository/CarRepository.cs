using System.Linq;
using ReviewApp.Data.Dto;
using ReviewApp.Interfaces;
using ReviewApp.Models;

namespace ReviewApp.Repository
{

    public class CarRepository: ICarRepository
    {

    private readonly DataContext _context;

        public CarRepository(DataContext context)
        {
            _context = context;
        }

        // Get all cars
        public ICollection<Car> GetCars()
        {
            return _context.Cars.OrderBy(p => p.Id).ToList();
        }

        // Get car by brand
        public Car GetCarByBrand(string brand)
        {
            return _context.Cars.Where(c => c.Brand == brand).FirstOrDefault();
        }

        // Get car by ID
        public Car GetCarById(Guid id)
        {
            return _context.Cars.Where(c => c.Id == id).FirstOrDefault();
        }


        // Check if car exists id
        public bool CarExists(Guid carId) => _context.Cars.Any(c => c.Id == carId);


        // Check if car exists brand
        public bool CarExists(string brand) => _context.Cars.Any(c => c.Brand == brand);

        //Create new car
        public bool CreateCar(Car car)
        {
            var createdCar = _context.Add(car);
            return Save();
        }

        //Save changes
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
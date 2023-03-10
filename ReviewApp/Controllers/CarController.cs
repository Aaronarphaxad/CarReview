using System;
using System.Runtime.ConstrainedExecution;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReviewApp.Data.Dto;
using ReviewApp.Interfaces;
using ReviewApp.Models;

namespace ReviewApp.Controllers
{
	//[Route("api/[controller]")]
	[Route("api/cars")]
    [ApiController]
	public class CarController : Controller
	{
		private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        // Controller constructor
        public CarController(ICarRepository carRepository, IMapper mapper)
		{
			_carRepository = carRepository;
            _mapper = mapper;
        }

		// Get all cars endpoint
		[HttpGet("all")]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
		public IActionResult GetCars() 
		{
			// mapper is used to apply DTO to the query results
			var Cars = _mapper.Map<List<CarDto>>(_carRepository.GetCars());

			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			return Ok(Cars);
		}

        // Get car by ID endpoint
        [HttpGet("car-id/{carId}")]
		[ProducesResponseType(200, Type = typeof(Car))]
		[ProducesResponseType(400)]
		public IActionResult GetCarById(Guid carId)
		{
			if (!_carRepository.CarExists(carId))
				return NotFound();
			var car = _mapper.Map<CarDto>(_carRepository.GetCarById(carId));

			if (!ModelState.IsValid)
				return BadRequest();

			return Ok(car);
		}

        // Get car by brand endpoint
        [HttpGet("car-brand/{brand}")]
		[ProducesResponseType(200, Type = typeof(CarDto))]
        [ProducesResponseType(400)]
        public IActionResult GetCarByBrand(string brand)
        {
            if (!_carRepository.CarExists(brand))
                return NotFound();
            var car = _mapper.Map<CarDto>(_carRepository.GetCarByBrand(brand));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(car);
        }

		// Add new car endpoint
		[HttpPost]
        [ProducesResponseType(200, Type = typeof(Car))]
        [ProducesResponseType(204)]
		[ProducesResponseType(400)]
		public ActionResult<Car> CreateCar([FromBody]CarRequest carData)
		{
            if (carData == null)
            {
                return BadRequest();
            }

            var car = new Car
            {
                Id = Guid.NewGuid(),
                Brand = carData.Brand,
                Model = carData.Model,
                Year = carData.Year,
                Color = carData.Color,
                Country = carData.Country,
                Mileage = carData.Mileage,
                Price = carData.Price,
                Rating = carData.Rating
            };
            bool isCarCreated = _carRepository.CreateCar(car);
            if (isCarCreated)
            {
                return Ok(car);
            }
            else
            {
                return StatusCode(500);
            }
        }
	}
}


  using System;
using AutoMapper;
using ReviewApp.Data.Dto;
using ReviewApp.Models;

namespace ReviewApp.Data.Helper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Car, CarDto>();
			CreateMap<CarDto, Car>();
		}
	}
}


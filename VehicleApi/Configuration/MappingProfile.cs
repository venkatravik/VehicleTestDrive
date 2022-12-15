using AutoMapper;
using VehiclesApi.Entity;
//using VehiclesApi.Migrations;
using VehiclesApi.Models;

namespace VehiclesApi.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vehicle,VehicleDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using CustomersApi.Entity;
using CustomersApi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CustomersApi.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();  
        }
    }
}

using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions; 


namespace Atm.Api.Data
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<AtmMachine, CreateAtmMachineDto>().ReverseMap();
            CreateMap<AtmMachine, AtmMachineDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<District, DistrictDto>().ReverseMap();


            
        }
    }
}

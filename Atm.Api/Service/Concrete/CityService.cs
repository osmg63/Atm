using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using AutoMapper;
using System.Linq.Expressions;

public class CityService : ICityService
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;   

    public CityService(ICityRepository cityRepository,IMapper mapper)
    {
        _mapper = mapper;
        _cityRepository = cityRepository;
    }

    public CityDto Get(int id)
    {
        var data=_cityRepository.Get(x=>x.Id==id);
        return _mapper.Map<CityDto>(data);

    }
   

    public List<CityDto> GetAll()
    {
        var data= _cityRepository.GetAll();

        return _mapper.Map<List<CityDto>>(data);
    }
}

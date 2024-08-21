using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using AutoMapper;
using System.Linq.Expressions;

public class CityService : ICityService
{
    private readonly IUnitOfWork _unitOfWork;

    

    private readonly IMapper _mapper;   

    public CityService(IMapper mapper,IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;

    }

    public CityDto Get(int id)
    {
        var data = _unitOfWork.CityRepository.Get(x=>x.Id==id);
        return _mapper.Map<CityDto>(data);

    }
    public List<DistrictDtoResponse> GetWithDistricts(int id)
    {
        return _unitOfWork.CityRepository.GetDistrictByCityId(id);
       

    }
    public List<AtmDtoForCityResponse> GetWithAtms(int id)
    {
        return _unitOfWork.CityRepository.GetAtmsWithCityId(id);


    }


    public List<CityDto> GetAll()
    {
        var data = _unitOfWork.CityRepository.GetAll();
        _unitOfWork.SaveChangesAsync();

        return _mapper.Map<List<CityDto>>(data);
    }
}

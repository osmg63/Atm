using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using System.Linq.Expressions;

public class CityService : ICityService
{
    private readonly ICityRepository _cityRepository;

    public CityService(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public City Get(Expression<Func<City, bool>> filter)
    {
        return _cityRepository.Get(filter);

    }

    public List<City> GetAll(Expression<Func<City, bool>> filter = null)
    {
        return _cityRepository.GetAll(filter);
    }
}

using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Core.Repository.Concrete;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Linq.Expressions;

namespace Atm.Api.Service.Concrete
{
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository districtRepository;
        private readonly IMapper _mapper;

        public DistrictService(IDistrictRepository districtRepository, IMapper mapper)
        {
            this.districtRepository = districtRepository;
            _mapper = mapper;
        }

        public DistrictDto Get(int id)
        {
            var data = districtRepository.Get(x=>x.Id==id);

            return _mapper.Map<DistrictDto>(data);
        }
        public List<DistrictDto> GetByCityId(int cityId)
        {
            var data = districtRepository.Get(x => x.CityId == cityId);
            return _mapper.Map<List<DistrictDto>>(data);

        }

        public List<DistrictDto> GetAll()
        {
            var data= districtRepository.GetAll();

            return _mapper.Map<List<DistrictDto>>(data);
        }
    }
}

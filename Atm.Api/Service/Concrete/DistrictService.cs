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
        private readonly IUnitOfWork _unitOfWork;

        public DistrictService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public DistrictDto Get(int id)
        {
            var data = _unitOfWork.DistrictRepository.Get(x=>x.Id==id);

            return _mapper.Map<DistrictDto>(data);
        }
        public List<DistrictDto> GetByCityId(int cityId)
        {
            var data = _unitOfWork.DistrictRepository.Get(x => x.CityId == cityId);
            return _mapper.Map<List<DistrictDto>>(data);

        }

        public List<DistrictDto> GetAll()
        {
            var data= _unitOfWork.DistrictRepository.GetAll();

            return _mapper.Map<List<DistrictDto>>(data);
        }
    }
}

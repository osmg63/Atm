using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Linq.Expressions;

namespace Atm.Api.Service.Concrete
{
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository districtRepository;

        public DistrictService(IDistrictRepository districtRepository)
        {
            this.districtRepository = districtRepository;
        }

        public District Get(Expression<Func<District, bool>> filter)
        {
            return districtRepository.Get(filter);
        }

        public List<District> GetAll(Expression<Func<District, bool>> filter = null)
        {
            return districtRepository.GetAll(filter);
        }
    }
}

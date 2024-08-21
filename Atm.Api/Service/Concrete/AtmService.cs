using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Filters;
using Atm.Api.Service.Abstract;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Atm.Api.Service.Concrete
{
    public class AtmService : IAtmService
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;
        private readonly IAtmMachineRepository _atmMachineRepository;

        public AtmService(IUnitOfWork unitOfWork, IMapper mapper, IAtmMachineRepository atmMachineRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _atmMachineRepository = atmMachineRepository;
        }

        public AtmMachineDto Add(CreateAtmMachineDto dto)
        {
            

            var data = _mapper.Map<AtmMachine>(dto);


            _unitOfWork.AtmMachineRepository.Add(data);
            _unitOfWork.AtmMachineRepository.SaveChanges();


            return _mapper.Map<AtmMachineDto>(data);
        }


        public void Delete(int id)
        {
            
            var data = _unitOfWork.AtmMachineRepository.Get(x=>x.Id==id);
            _unitOfWork.AtmMachineRepository.Delete(data);

        }

        public AtmMachineDto Get(int id)
        {

            var data = _unitOfWork.AtmMachineRepository.Get(x => x.Id == id);
            return _mapper.Map<AtmMachineDto>(data);
        }

        public List<AtmMachineDto> GetAll()
        {
            var data = _unitOfWork.AtmMachineRepository.GetAll();
            return _mapper.Map<List<AtmMachineDto>>(data);
        }


        public void Update(UpdateAtmMachineDto dto)
        {
           

            var data = _unitOfWork.AtmMachineRepository.Get(x => x.Id == dto.Id);
            if (data != null)
            {

                data.Name = dto.Name;
                data.IsActive = dto.IsActive;
                data.Adress = dto.Adress;
                data.Latitude = dto.Latitude;
                data.Longitude = dto.Longitude;
                data.CityId = dto.CityId;
                data.DistrictId = dto.DistrictId;


            }
            _unitOfWork.AtmMachineRepository.SaveChanges();
        }

        public AtmMachineDto GetById(int id)
        {

            return _unitOfWork.AtmMachineRepository.GetById(id);
        }

        public List<AtmMachineDto> GetAllWithCityAndDistrictName()
        {
            return _unitOfWork.AtmMachineRepository.GetAllWithCityAndDistrictName();
        }

        public Task<PaginatedResult<AtmMachineDto>> GetPaginationView(FilterDTO filter)
        {
            return _unitOfWork.AtmMachineRepository.GetPaginationView(filter);
        }
    }

}


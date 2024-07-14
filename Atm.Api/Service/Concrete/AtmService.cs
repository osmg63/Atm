using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Core.Repository.Concrete;
using Atm.Api.Data;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Validations;
using Atm.Api.Service.Abstract;
using AutoMapper;
using FluentValidation;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Atm.Api.Service.Concrete
{
    public class AtmService : IAtmService
    {
        private readonly IMapper _mapper;

        private readonly IAtmMachineRepository _atmMachineRepository;

        public AtmService(IAtmMachineRepository atmMachineRepository, IMapper mapper)
        {
            this._atmMachineRepository = atmMachineRepository;
            _mapper = mapper;
        }

        public AtmMachineDto Add(CreateAtmMachineDto dto)
        {
            

            var data = _mapper.Map<AtmMachine>(dto);


            _atmMachineRepository.Add(data);
            _atmMachineRepository.SaveChanges();


            return _mapper.Map<AtmMachineDto>(data);
        }


        public void Delete(int id)
        {
            
            var data = _atmMachineRepository.Get(x=>x.Id==id);
            _atmMachineRepository.Delete(data);

        }

        public AtmMachineDto Get(int id)
        {

            var data = _atmMachineRepository.Get(x => x.Id == id);
            return _mapper.Map<AtmMachineDto>(data);
        }

        public List<AtmMachineDto> GetAll()
        {
            var data = _atmMachineRepository.GetAll();
            return _mapper.Map<List<AtmMachineDto>>(data);
        }


        public void Update(UpdateAtmMachineDto dto)
        {
           

            var data = _atmMachineRepository.Get(x => x.Id == dto.Id);
            if (data != null)
            {

                data.Name = dto.Name;
                data.IsActive = dto.IsActive;
               //data.Adress = dto.Adress;
                //data.Latitude = dto.Latitude;
                //data.Longitude = dto.Longitude;
                //data.CityId = dto.CityId;
                //data.DistrictId = dto.DistrictId;


            }
            _atmMachineRepository.SaveChanges();
        }

        public AtmMachineDto GetById(int id)
        {

            return _atmMachineRepository.GetById(id);
        }

        public List<AtmMachineDto> GetAllWithCityAndDistrictName()
        {
            return _atmMachineRepository.GetAllWithCityAndDistrictName();
        }

        //Validation

    }
}

﻿using Atm.Api.Data.DTOs;
using Atm.Api.Data.Filters;
using Atm.Api.Data.Validations;
using Atm.Api.Service.Abstract;

using Microsoft.AspNetCore.Mvc;


namespace Atm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtmController : ControllerBase
    {
        private readonly IAtmService _atmService;

        public AtmController(IAtmService atmService)
        {
            _atmService = atmService;
        }
        
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {

            var data = _atmService.GetById(id);
            return Ok(data);
        }
       
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _atmService.GetAllWithCityAndDistrictName    ();
            return Ok(data);
        }

        [HttpPost("Create")]
        public IActionResult Add(CreateAtmMachineDto dto)
        {
            var validator = new CreateAtmMachineDtoValidator();
            var result = validator.Validate(dto);

            if (!result.IsValid)
            {
                BadRequest(result.Errors.Select(x => x.ErrorMessage).ToList());

            }

            var data = _atmService.Add(dto);
            return Ok(data);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateAtmMachineDto dto)
        {
            var validator = new UpdateAtmMachineDtoValidator();
            var result = validator.Validate(dto);

            if (!result.IsValid)
            {
                BadRequest(result.Errors.Select(x => x.ErrorMessage).ToList());
            }
            _atmService.Update(dto);


            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }        
        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            _atmService.Delete(id);
            return Ok();
        }
    

       [HttpPost("Pagination")]
        public async Task<IActionResult> GetPaginationView(FilterDTO filter)
        {
            var data = await _atmService.GetPaginationView(filter) ;

            return Ok(data);
        }
    }
    
}


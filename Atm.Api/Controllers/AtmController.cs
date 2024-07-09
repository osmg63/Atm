using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Validations;
using Atm.Api.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

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

            var data = _atmService.Get(id);
            return Ok(data);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _atmService.GetAll();
            return Ok(data);
        }
        [HttpPost("Create")]
        public IActionResult Add(CreateAtmMachineDto dto)
        {
         
            var data = _atmService.Add(dto);
            return Ok(data);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateAtmMachineDto dto)
        {
            _atmService.Update(dto);


            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            _atmService.Delete(id);
            return Ok();
        }
    }
}
// Async Task kullanımı

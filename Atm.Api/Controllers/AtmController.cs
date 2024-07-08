using Atm.Api.Data.Entities;
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
        [HttpGet("id")]
        public IActionResult GetById(int id) {
            Expression<Func<AtmMachine, bool>> filter = atm => atm.Id == id;
            var data =_atmService.Get(filter);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Add([FromBody] AtmMachine entity)
        {
            _atmService.Add(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] AtmMachine entity)
        {
            _atmService.Update(entity);

          
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpDelete("id")]
        public IActionResult DeleteById(int id) {
             _atmService.Delete(id);
            return Ok();
        }
    }
}

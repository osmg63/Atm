using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Atm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetById/{id}")]
        public IActionResult Get(int id)
        {
            
            var data = _districtService.Get(id);
            return Ok(data);

        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            
            var data = _districtService.GetAll();
            return Ok(data);

        }
    }
}

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

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            Expression<Func<District, bool>> filter = x => x.Id == id;
            var data = _districtService.Get(filter);
            return Ok(data);

        }
        [HttpGet("Filter")]
        public IActionResult GetFilter([FromQuery] string filter = null)
        {
            Expression<Func<District, bool>> filt = null;
            var data = _districtService.Get(filt);
            return Ok(data);

        }
    }
}

using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using Atm.Api.Service.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Atm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            Expression<Func<City, bool>> filter = x => x.Id == id;
            var data = _cityService.Get(filter);
            return Ok(data);

        }
        [HttpGet("Filter")]
        public IActionResult GetFilter([FromQuery] string filter=null)
        {
            Expression<Func<City, bool>> filt = null;
            var data = _cityService.Get(filt);
            return Ok(data);

        }
        //pagenation metodları

    }
}

using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using Atm.Api.Service.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using X.PagedList;

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

        [HttpGet("GetById/{id}")]
        public IActionResult Get(int id)
        {
            
            var data = _cityService.Get(id);
            return Ok(data);

        }
        [HttpGet("GetByCityIdDistrict/{cityId}")]
        public IActionResult GetDistrict(int cityId)
        {

            var data = _cityService.GetWithDistricts(cityId);
            return Ok(data);

        }
        [HttpGet("GetByCityIdAtms/{cityId}")]
        public IActionResult GetAtm(int cityId)
        {

            var data = _cityService.GetWithAtms(cityId);
            return Ok(data);

        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            
            var data = _cityService.GetAll();
            return Ok(data);

        }
        
        //pagenation metodları

    }
}

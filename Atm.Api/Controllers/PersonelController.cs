using Atm.Api.Core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {

       private readonly IPersonelRepository _personelRepository;

        public PersonelController(IPersonelRepository personelRepository)
        {
            this._personelRepository = personelRepository;
        }


        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var data=_personelRepository.GetAll();
            return Ok(data);
        }
    }
}

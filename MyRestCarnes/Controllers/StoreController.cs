using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyRestCarnes.Model;
using MyRestCarnes.Business;
using MyRestCarnes.Data.VO;

namespace MyRestCarnes.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;
        private IStoreBusiness _storeBusiness;

        public StoreController(ILogger<StoreController> logger, IStoreBusiness storeBusiness)
        {
            _logger = logger;
            _storeBusiness = storeBusiness;
        }

        [HttpGet]
        public IActionResult GetShops() 
        {
            return Ok(_storeBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetStore(long id) 
        {
            var store = _storeBusiness.FindByID(id);
            if (store == null) return NotFound();

            return Ok(store);
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] StoreVO store)
        {
            if (store == null) return BadRequest();

            return Ok(_storeBusiness.Create(store));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStore([FromBody] StoreVO store)
        {
            if (store == null) return BadRequest();
            return Ok(_storeBusiness.Update(store));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _storeBusiness.Delete(id);
            return NoContent();
        }
    }
}

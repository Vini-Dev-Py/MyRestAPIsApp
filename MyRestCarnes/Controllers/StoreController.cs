using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyRestCarnes.Model;
using MyRestCarnes.Services;

namespace MyRestCarnes.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;
        private IStoreService _storeService;

        public StoreController(ILogger<StoreController> logger, IStoreService storeService)
        {
            _logger = logger;
            _storeService = storeService;
        }

        [HttpGet]
        public IActionResult GetShops() 
        {
            return Ok(_storeService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetStore(long id) 
        {
            var store = _storeService.FindByID(id);
            if (store == null) return NotFound();

            return Ok(store);
        }

        [HttpPost]
        public IActionResult CreateStore([FromBody] Store store)
        {
            if (store == null) return BadRequest();

            return Ok(_storeService.Create(store));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStore([FromBody] Store store)
        {
            if (store == null) return BadRequest();
            return Ok(_storeService.Update(store));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            try
            {
                _storeService.Delete(id);

                return Ok($"Store number {id} sucessfully deleted");
            }
            catch (Exception)
            {
                return BadRequest($"Store number {id} was not deleted successfully");
            }
        }
    }
}

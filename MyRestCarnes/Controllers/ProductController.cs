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
    public class ProductController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;
        private IProductBusiness _productBusiness;

        public ProductController(ILogger<StoreController> logger, IProductBusiness productBusiness)
        {
            _logger = logger;
            _productBusiness = productBusiness;
        }

        [HttpGet]
        public IActionResult GetProducts() 
        {
            return Ok(_productBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(long id) 
        {
            var store = _productBusiness.FindByID(id);
            if (store == null) return NotFound();

            return Ok(store);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductVO product)
        {
            if (product == null) return BadRequest();
            return Ok(_productBusiness.Create(product));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody] ProductVO product)
        {
            if (product == null) return BadRequest();
            return Ok(_productBusiness.Update(product));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(long id)
        {
            _productBusiness.Delete(id);
            return NoContent();
        }
    }
}

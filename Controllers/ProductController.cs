using Microsoft.AspNetCore.Mvc;
using WebAPI_RepositoryPattern.Service;
using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        public ProductController(ProductService service) { _service = service; }

        //create
        [HttpPost("create")]
        public IActionResult Create(Product product)
        {
             _service.create_product(product);
            return CreatedAtAction(nameof(ReadByID), new { Id = product.Id},product);
        }
        //read
        [HttpGet("getall")]
        public IActionResult Read()
        {
            var products = _service.read_product();
            return Ok(products);
        }
        //readbyid
        [HttpGet("getbyid")]
        public IActionResult ReadByID([FromQuery]int id)
        {
            var products = _service.readbyid_product(id);
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound("Product not found");
        }
        //update
        [HttpPut("update")]
        public IActionResult Update([FromBody] Product product,[FromQuery] int id)
        {
            var existing = _service.readbyid_product(id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Weight = product.Weight;
                _service.update_product(existing);
                return Ok();
            }
            return NotFound("Product not found");

        }
        //delete
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _service.readbyid_product(id);
            if (existing != null)
            {
                _service.delete_product(id);
                return Ok();
            }
            return NotFound("Product not found");

        }
    }
}

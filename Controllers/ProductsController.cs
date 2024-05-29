using Microsoft.AspNetCore.Mvc;
using WebApplication15.Models;
using WebApplication15.Services;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            var createdProduct = _productService.CreateProductAsync(product);
            return CreatedAtAction(nameof(GetAllProducts), new { id = createdProduct.Id }, createdProduct);
        }
    }
}

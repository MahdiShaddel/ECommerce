using ECommerce.InfraStructure.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.InfraStructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository Productrepository;
        public ProductsController(IProductRepository productRepository)
        {
            Productrepository = productRepository;
        }

        [HttpGet("ProductsList")]
        public async Task<IActionResult> GetProductsAsync()
        {
            var result = await Productrepository.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("Products")]
        public async Task<IActionResult> GetProductsAsync(int id)
        {
            var result = await Productrepository.GetProductsAsync(id);
            return Ok(result);
        }
    }
}

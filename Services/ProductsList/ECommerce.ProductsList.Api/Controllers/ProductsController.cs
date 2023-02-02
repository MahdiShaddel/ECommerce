using ECommerce.Products.Api.Response;
using ECommerce.ProductsList.Application.ApplicationServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.ProductsList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService ProductService;
        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet("ProductList")]
        public async Task<IActionResult> ProductList()
        {
            return ResponseUtil.ResultMessage(await ProductService.ProductList());
        }
    }
}
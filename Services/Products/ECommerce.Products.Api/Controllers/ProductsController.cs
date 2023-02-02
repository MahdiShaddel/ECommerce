using ECommerce.Products.Api.Response;
using ECommerce.Products.Application.ApplicationServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.ProductsDetail.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsServices ProductService;
        public ProductsController(IProductsServices productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        [Route("Products")]
        public async Task<IActionResult> Products(int id)
        {
            return ResponseUtil.ResultMessage(await ProductService.GetProductAsync(id));
        }
    }
}

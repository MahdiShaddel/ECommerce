using ECommerce.Products.Application.Contract.DTOs;
using ECommerce.Products.Application.Contract.RespondResult;

namespace ECommerce.Products.Application.ApplicationServices.IServices
{
    public interface IProductsServices
    {
        Task<ICustomeRespondResult<ProductsDTO>> GetProductAsync(int id);
    }
}

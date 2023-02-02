using ECommerce.ProductsList.Application.Contract.DTOs;
using ECommerce.ProductsList.Application.Contract.RespondResult;

namespace ECommerce.ProductsList.Application.ApplicationServices.IServices
{
    public interface IProductService
    {
        Task<ICustomeRespondResult<List<ProductsDTO>>> ProductList();
    }
}

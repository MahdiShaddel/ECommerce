using ECommerce.InfraStructure.Models;
using ECommerce.InfraStructure.Repositories.Repository;

namespace ECommerce.InfraStructure.Repositories.IRepository
{
    public interface IProductRepository
    {
        Task<Products> GetProductsAsync(object id);
        Task<IEnumerable<Products>> GetProductsAsync();
    }
}

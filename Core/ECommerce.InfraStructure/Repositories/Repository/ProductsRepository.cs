using ECommerce.InfraStructure.Contexts;
using ECommerce.InfraStructure.Models;
using ECommerce.InfraStructure.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.InfraStructure.Repositories.Repository
{
    public class ProductsRepository : IProductRepository
    {
        private readonly ECommerceContext Context;
        public ProductsRepository(ECommerceContext context)
        {
            Context = context;
        }

        public async Task<Products> GetProductsAsync(object id)
        {
            return await Context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Products>> GetProductsAsync()
        {
            return await Context.Products.ToListAsync();
        }
    }

}

using ECommerce.InfraStructure.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.InfraStructure.Contexts
{
    public class ECommerceContext : DbContext
    {

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}

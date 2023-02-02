using ECommerce.InfraStructure.Contexts;
using ECommerce.InfraStructure.Models;

namespace ECommerce.InfraStructure.SeedData
{
    public class FillInMemoryDB
    {
        private readonly IServiceProvider serviceProvider;

        public FillInMemoryDB(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void FillData()
        {
            var context = serviceProvider.GetRequiredService<ECommerceContext>();
            context.Add(new Products { Id = 1, Name = "Burger", Price = 1200, Inventory = "Fastfood" });
            context.Add(new Products { Id = 2, Name = "Pizza", Price = 2000, Inventory = "Fastfood" });
            context.Add(new Products { Id = 3, Name = "Sandwich", Price = 1500, Inventory = "Fastfood" });
            context.Add(new Products { Id = 4, Name = "Donner", Price = 800, Inventory = "Fastfood" });
            context.Add(new Products { Id = 5, Name = "Barbecue", Price = 1800, Inventory = "Fastfood" });
            context.SaveChanges();
        }
    }
}

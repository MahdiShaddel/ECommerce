namespace ECommerce.Products.Application.Contract.DTOs
{
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Inventory { get; set; }
    }
}

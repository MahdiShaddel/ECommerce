using System.ComponentModel.DataAnnotations;

namespace ECommerce.InfraStructure.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Inventory { get; set; }
    }
}

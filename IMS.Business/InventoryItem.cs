using System.ComponentModel.DataAnnotations;

namespace IMS.Business
{
    public class InventoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quantity greater than or equal to 0")]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price greater than or equal to 0")]
        public double Price { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace ecommerce_razor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(1, 100)]
        public int? DisplayOrder { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

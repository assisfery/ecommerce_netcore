using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecommerce_netcore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [DisplayName("Display Name")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime UpdatedDateTime { get; set; }
    }
}

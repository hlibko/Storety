using System.ComponentModel.DataAnnotations;

namespace Storety.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public int DisplayOrder { get; set; } = 0;
    }
}

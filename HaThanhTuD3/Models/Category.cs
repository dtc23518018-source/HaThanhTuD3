using System.ComponentModel.DataAnnotations;

namespace HaThanhTuD3.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "so can phai nam trong 3 - 100.")]
        public string? Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

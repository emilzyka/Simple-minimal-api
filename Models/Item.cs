using System.ComponentModel.DataAnnotations;
namespace MinimalAPI.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        [StringLength(10000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(100)]
        public string? Developer { get; set; }

        [Required]
        [StringLength(100)]
        public string? Publisher { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Platform  { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Genre { get; set; }

        [StringLength(1000)]
        public string? Mode { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Release { get; set; }

    }
}

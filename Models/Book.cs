using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookVerse.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Author is required")]
        [StringLength(80, ErrorMessage = "Author cannot exceed 80 characters")]
        [Display(Name = "Author")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(1.00, 1000.00, ErrorMessage = "Price must be between 1 and 1000")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateOnly PublishDate { get; set; }

        [Range(10, 3000, ErrorMessage = "Pages must be between 10 and 3000")]
        [Display(Name = "Pages")]
        public int Pages { get; set; }

        [StringLength(50, ErrorMessage = "Language cannot exceed 50 characters")]
        [Display(Name = "Language")]
        public string Language { get; set; } = "English";

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

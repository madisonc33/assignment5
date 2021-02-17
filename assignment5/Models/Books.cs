using System;
using System.ComponentModel.DataAnnotations;
namespace assignment5.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{3}-[0-9]{10}", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public double Price { get; set; }
    }
}

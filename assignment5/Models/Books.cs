using System;
using System.ComponentModel.DataAnnotations;
namespace assignment5.Models
{
    //Book class that will be in our DB - all are required
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string AuthorMiddle { get; set; } = "";

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double NumberOfPages { get; set; }
    }
}

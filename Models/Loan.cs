using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required]
        public string BorrowerName { get; set; } = string.Empty;

        [Required]
        public DateTime ReturnDate { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}

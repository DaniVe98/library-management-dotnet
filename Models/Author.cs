using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public required string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}

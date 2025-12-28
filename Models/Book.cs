using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
  public class Book
  {
      public int Id { get; set; }

      [Required(ErrorMessage = "El título es obligatorio")]
      [StringLength(150, ErrorMessage = "Máximo 150 caracteres")]
      public string Title { get; set; } = string.Empty;

      [Required(ErrorMessage = "El autor es obligatorio")]
      public int AuthorId { get; set; }

      public Author? Author { get; set; }
  }

}

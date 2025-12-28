using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
  public class BooksController : Controller
  {
      private readonly LibraryContext _context;

      public BooksController(LibraryContext context)
      {
          _context = context;
      }

      public IActionResult Create()
      {
          ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
          return View();
      }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Book book)
    {
        Console.WriteLine("ENTRÓ AL POST");

        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"AuthorId: {book.AuthorId}");

        if (!ModelState.IsValid)
        {
            Console.WriteLine("MODELSTATE INVALIDO");
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }

        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
        return View(book);
    }

  }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Data;

namespace LibraryManagement.Controllers
{
  public class HomeController : Controller
  {
      private readonly LibraryContext _context;

      public HomeController(LibraryContext context)
      {
          _context = context;
      }

      public async Task<IActionResult> Index()
      {
          var books = await _context.Books
              .Include(b => b.Author)
              .ToListAsync();

          return View(books);
      }
  }
}
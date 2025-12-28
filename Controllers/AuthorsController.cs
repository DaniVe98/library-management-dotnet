using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
  public class AuthorsController : Controller
  {
      private readonly LibraryContext _context;

      public AuthorsController(LibraryContext context)
      {
          _context = context;
      }

      public IActionResult Create()
      {
          return View();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Create(Author author)
      {
          if (ModelState.IsValid)
          {
              _context.Authors.Add(author);
              await _context.SaveChangesAsync();
              return RedirectToAction("Index", "Home");
          }

          return View(author);
      }
  }
}
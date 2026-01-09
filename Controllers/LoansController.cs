using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
    public class LoansController : Controller
    {
        private readonly LibraryContext _context;

        public LoansController(LibraryContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Create(int bookId)
        {
            var book = _context.Books.Find(bookId);

            if (book == null || book.Stock == 0)
            {
                return BadRequest("No hay stock disponible");
            }

            ViewBag.BookTitle = book.Title;
            ViewBag.BookId = book.Id;

            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Loan loan)
        {
            var book = await _context.Books.FindAsync(loan.BookId);

            // Validación de stock
            if (book == null || book.Stock == 0)
            {
                ModelState.AddModelError("", "No hay stock disponible");
            }

            if (loan.ReturnDate.Date < DateTime.Today)
            {
                ModelState.AddModelError(
                    "ReturnDate",
                    "La fecha de devolución no puede ser anterior a hoy"
                );
            }

            // Si algo falló, vuelve a la vista
            if (!ModelState.IsValid)
            {
                ViewBag.BookTitle = book?.Title;
                ViewBag.BookId = loan.BookId;
                return View(loan);
            }

            // Lógica normal del préstamo
            book.Stock -= 1;

            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}

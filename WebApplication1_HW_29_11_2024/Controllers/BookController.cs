using Microsoft.AspNetCore.Mvc;
using WebApplication1_HW_29_11_2024.Models;
using WebApplication1_HW_29_11_2024.Services;
using WebApplication1_HW_29_11_2024.ViewModels;

namespace WebApplication1_HW_29_11_2024.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = model.Title,
                    Author = model.Author,
                    Genre = model.Genre,
                    Year = model.Year
                };

                _bookService.AddBook(book);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

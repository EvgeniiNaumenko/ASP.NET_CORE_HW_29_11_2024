using WebApplication1_HW_29_11_2024.Models;

namespace WebApplication1_HW_29_11_2024.Services
{
    public class BookService
    {
        private readonly List<Book> _books = new List<Book>();

        public IEnumerable<Book> GetAllBooks() => _books;

        public void AddBook(Book book)
        {
            book.Id = _books.Count + 1;
            _books.Add(book);
        }
    }
}

using DotNetWebAPI_InMemoryDatabase.Data;
using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public class BookServices : IBooks
    {
        private readonly BookContext _context;
        private readonly ILogger<BookServices> _logger;

        public BookServices(BookContext context, ILogger<BookServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddBook(Book book)
        {
            _logger.LogInformation("Attempting to add a new book with Title: {Title}", book.Title);

            _context.Books.Add(book);
            _context.SaveChanges();

            _logger.LogInformation("Book added successfully with Id: {Id}", book.Id);
        }

        public void DeleteBook(int bookid)
        {
            _logger.LogInformation("Attempting to delete book with Id: {Id}", bookid);

            var book = _context.Books.FirstOrDefault(x => x.Id == bookid);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();

                _logger.LogInformation("Book deleted successfully with Id: {Id}", bookid);
            }
            else
            {
                _logger.LogWarning("Delete failed. Book not found with Id: {Id}", bookid);
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            _logger.LogInformation("Fetching all books");

            var books = _context.Books.AsNoTracking().ToList();

            _logger.LogInformation("Total books retrieved: {Count}", books.Count);

            return books;
        }

        public Book GetBook(int bookid)
        {
            _logger.LogInformation("Fetching book with Id: {Id}", bookid);

            var book = _context.Books.FirstOrDefault(book => book.Id == bookid);

            if (book != null)
            {
                _logger.LogInformation("Book found with Id: {Id}", bookid);
                return book;
            }

            _logger.LogWarning("Book not found with Id: {Id}", bookid);
            return null;
        }

        public void UpdateBook(Book book)
        {
            _logger.LogInformation("Attempting to update book with Id: {Id}", book.Id);

            _context.Update(book);
            _context.SaveChanges();

            _logger.LogInformation("Book updated successfully with Id: {Id}", book.Id);
        }
    }
}
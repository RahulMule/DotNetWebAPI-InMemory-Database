using DotNetWebAPI_InMemoryDatabase.Models;
using DotNetWebAPI_InMemoryDatabase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooks _books;
        public BooksController(IBooks books)
        {
            _books = books;      
        }
        [HttpGet]
        public IActionResult GetAllBooks() 
        {
            IEnumerable<Book> books = _books.GetAllBooks();
            return Ok(books);
        }
        [HttpPost]
        public IActionResult AddBook(Book book) 
        {
            _books.AddBook(book);
            return Ok();
        }

    }
}

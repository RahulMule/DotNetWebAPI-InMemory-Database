using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface IBooks
    {
        public IEnumerable<Book> GetAllBooks();
        public void AddBook(Book book);
    }
}

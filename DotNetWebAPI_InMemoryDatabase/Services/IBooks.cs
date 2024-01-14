using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface IBooks
    {
        public IEnumerable<Book> GetAllBooks();
        public void AddBook(Book book);
        public void DeleteBook(int bookid);
        public void UpdateBook(Book book);
        public Book GetBook(int bookid);
    }
}

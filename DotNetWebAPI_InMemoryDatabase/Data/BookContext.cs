using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebAPI_InMemoryDatabase.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
      
    }
}

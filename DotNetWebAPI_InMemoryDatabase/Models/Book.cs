using System.ComponentModel.DataAnnotations;

namespace DotNetWebAPI_InMemoryDatabase.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}

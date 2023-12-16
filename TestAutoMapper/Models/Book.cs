using System.ComponentModel.DataAnnotations;

namespace TestAutoMapper.Models
{

    // Domain Model
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string  Author { get; set; }
        public double Price { get; set; }
    }
}

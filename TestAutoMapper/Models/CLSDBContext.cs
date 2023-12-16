using Microsoft.EntityFrameworkCore;

namespace TestAutoMapper.Models
{
    public class CLSDBContext:DbContext
    {
        public CLSDBContext(DbContextOptions<CLSDBContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}

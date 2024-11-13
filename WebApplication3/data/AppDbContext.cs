using Microsoft.EntityFrameworkCore;
using BookApp.Models;

namespace BookApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}

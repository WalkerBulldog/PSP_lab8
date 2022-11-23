using lab8.Models;
using Microsoft.EntityFrameworkCore;

namespace lab8.Data
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
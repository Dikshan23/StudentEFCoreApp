// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using StudentEFCoreApp12.Models;


namespace StudentEFCoreApp12.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

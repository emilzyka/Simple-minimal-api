using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Item> Item { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using product_service.Models;

namespace product_service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Sea.Ecommerce.Repository.Models;

namespace Sea.Ecommerce.Repository
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }
    }
}

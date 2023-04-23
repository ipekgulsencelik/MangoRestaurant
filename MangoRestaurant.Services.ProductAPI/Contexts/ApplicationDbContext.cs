using MangoRestaurant.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoRestaurant.Services.ProductAPI.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
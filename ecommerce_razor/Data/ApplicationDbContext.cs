using ecommerce_razor.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}

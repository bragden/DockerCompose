using Microsoft.EntityFrameworkCore;
using DockerCompose.Models;

namespace DockerCompose.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

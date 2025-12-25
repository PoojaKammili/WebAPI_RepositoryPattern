using Microsoft.EntityFrameworkCore;
using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.dbContext
{
    public class ProductDbContext : DbContext
    {
       public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options){}
        public DbSet<Product> Products { get;set; }
       
    }
}

using Microsoft.EntityFrameworkCore;
using VSCode_WebAPI.Models;

namespace VSCode_WebAPI.Data
{
    public class MyProductsContext : DbContext
    {
        public MyProductsContext(DbContextOptions<MyProductsContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
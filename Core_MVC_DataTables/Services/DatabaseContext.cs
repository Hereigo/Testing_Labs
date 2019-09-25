using Core_MVC_DataTables.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_MVC_DataTables.Services
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
    }
}
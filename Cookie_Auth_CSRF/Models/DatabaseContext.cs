using Microsoft.EntityFrameworkCore;

namespace Cookie_Auth_CSRF.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
			Database.EnsureCreated(); // Replaced with Migrations.
		}

		// protected override void OnConfiguring(DbContextOptionsBuilder contextBuilder)
		// {
		//     contextBuilder.UseSqlite("DataSource=AuthUsers.db");
		// }

		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Role roleAdmins = new Role() { Id = 1, Name = "Admins" };
			Role roleUsers = new Role() { Id = 2, Name = "Users" };

			User userAdmin = new User { Id = 1, Email = "aaa@aaa", Password = "111", RoleId = roleAdmins.Id };

			modelBuilder.Entity<Role>().HasData(new Role[] { roleAdmins, roleUsers });
			modelBuilder.Entity<User>().HasData(new User[] { userAdmin });

			base.OnModelCreating(modelBuilder);
		}
	}
}

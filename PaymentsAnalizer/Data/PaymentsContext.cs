using Microsoft.EntityFrameworkCore;
using PaymentsAnalizer.Models;

namespace PaymentsAnalizer.Data
{
	public class PaymentsContext : DbContext
	{
		public PaymentsContext(DbContextOptions<PaymentsContext> dbContextOptions) : base(dbContextOptions)
		{
			// Database.EnsureDeleted();
			// Database.EnsureCreated();
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Payment> Payments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { ID = 01, Name = "CDA", IsActive = true },
				new Category { ID = 02, Name = "CDB", IsActive = true },
				new Category { ID = 03, Name = "CEX", IsActive = true },
				new Category { ID = 04, Name = "CLO", IsActive = true },
				new Category { ID = 05, Name = "CSH", IsActive = true },
				new Category { ID = 06, Name = "ENJ", IsActive = true },
				new Category { ID = 07, Name = "FOO", IsActive = true },
				new Category { ID = 08, Name = "FRD", IsActive = true },
				new Category { ID = 09, Name = "HLS", IsActive = true },
				new Category { ID = 10, Name = "HOM", IsActive = true },
				new Category { ID = 11, Name = "KID", IsActive = true },
				new Category { ID = 12, Name = "KIU", IsActive = true },
				new Category { ID = 13, Name = "KSH", IsActive = true },
				new Category { ID = 14, Name = "NRG", IsActive = true },
				new Category { ID = 15, Name = "PEB", IsActive = true },
				new Category { ID = 16, Name = "QVN", IsActive = true },
				new Category { ID = 17, Name = "STU", IsActive = true },
				new Category { ID = 18, Name = "VIH", IsActive = true },
				new Category { ID = 19, Name = "VLG", IsActive = true }
			);
		}
	}
}
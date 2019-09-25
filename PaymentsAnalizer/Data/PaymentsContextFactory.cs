using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PaymentsAnalizer.Data
{
    public class PaymentsContextFactory : IDesignTimeDbContextFactory<PaymentsContext>
    {
        public PaymentsContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PaymentsContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<PaymentsContext>();

            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PaymentsContext-2019-05-07;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new PaymentsContext(dbContextOptionsBuilder.Options);
        }
    }
}
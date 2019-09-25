using Core_MVC_DataTables.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC_DataTables.Services
{
    public static class DatabaseSeeding
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            await AddFakeData(services.GetRequiredService<DatabaseContext>());
        }

        public static async Task AddFakeData(DatabaseContext context)
        {
            if (context.Users.Any())
            {
                // Already has data
                return;
            }

            List<UserModel> fakeData = new List<UserModel>();

            for (int i = 0; i < 10; i++)
            {
                fakeData.Add(new UserModel()
                {
                    Created = DateTime.Now.AddDays(-1 * Faker.RandomNumber.Next(365)),
                    Name = Faker.Name.FullName(),
                    Id = Faker.RandomNumber.Next(999),
                    IsActive = Faker.RandomNumber.Next(2) == 1,
                    Number = Faker.RandomNumber.Next(),
                });
            }

            context.Users.AddRange(fakeData);

            await context.SaveChangesAsync();
        }
    }
}

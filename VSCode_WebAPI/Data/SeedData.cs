using System.Linq;
using VSCode_WebAPI.Models;

namespace VSCode_WebAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(MyProductsContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Squeaky Bone",
                        Price = 20.99m
                    },
                    new Product
                    {
                        Name = "Knotted Rope",
                        Price = 12.99m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services;

namespace WpfApp1.Models
{
    public class DataGenerator
    {
        public static void Initialize(ProductsDbContext context)
        {
            //Look for any board games.
            if (context.Products.Any())
                {
                    return;   // Data was already seeded
                }

            context.Products.AddRange(
                new Products { ProductId = 7488, Barcode = "S000001", Name = "PRODUCT A", Description = "TestData1", Price = 1000.0, Source = "EntityFramework - InMemoryDB" },
                new Products { ProductId = 7489, Barcode = "S000002", Name = "PRODUCT B", Description = "TestData2", Price = 1000.0, Source = "EntityFramework - InMemoryDB" },
                new Products { ProductId = 7490, Barcode = "S000003", Name = "PRODUCT C", Description = "TestData3", Price = 1000.0, Source = "EntityFramework - InMemoryDB" },
                new Products { ProductId = 7491, Barcode = "S000004", Name = "PRODUCT D", Description = "TestData4", Price = 1000.0, Source = "EntityFramework - InMemoryDB" });
            context.SaveChanges();
        }
    }
}

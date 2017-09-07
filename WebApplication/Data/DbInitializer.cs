using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            var productCategory1 = new ProductCategory { Name = "TV" };
            var productCategory2 = new ProductCategory { Name = "DVD" };
            var productCategory3 = new ProductCategory { Name = "VHS" };

            context.AddRange(productCategory1, productCategory2, productCategory3);

            context.SaveChanges();
        }
    }
}

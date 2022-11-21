using HandlingConcurrencyConflictsProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HandlingConcurrencyConflictsProject.Services
{
    public class HandlingConcurrencyConflicts
    {
        public async Task Process()
        {
            var tasks = new[]
            {
                Task.Factory.StartNew(() => UpdateUser()),
                Task.Factory.StartNew(() => UpdateUser()),
                Task.Factory.StartNew(() => UpdateUser())
            };
            
            var things = await Task.WhenAll(tasks);
        }

        public async Task UpdateUser()
        {
            using var dbcontext = new ProductsContext();

            while (true)
            {
                try
                {
                    var product = dbcontext.Products.FirstOrDefault();
                    product.Name = "Test123";
                    dbcontext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine($"ConcurencyError {ex}");
                }
            }
        }

    }
}

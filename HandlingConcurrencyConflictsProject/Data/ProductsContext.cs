using HandlingConcurrencyConflictsProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandlingConcurrencyConflictsProject.Data
{
    public class ProductsContext : DbContext
    {
        public DbSet<ProductsEntities> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SFKK8VV\\SQLEXPRESS;Database=HandlingDb;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}

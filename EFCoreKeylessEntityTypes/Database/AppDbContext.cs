using EFCoreKeylessEntityTypes.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EFCoreKeylessEntityTypes.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<QLink> QLink { get; set; }

        public DbSet<SalesOrders> SalesOrders { get; set; }

        public DbSet<SalesOrdersItems> SalesOrdersItems { get; set; }

        public DbSet<AvailablePartsKeyless> AvailableParts { get; set; }
        

        public AppDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AvailablePartsKeyless>().HasNoKey().ToView(null);

            DataSeeding.Seed(modelBuilder);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class ScDataContext : DbContext
    {

        public ScDataContext(DbContextOptions<ScDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CustomerDb>()
            //   .HasMany(b => b.Clients)
            //   .WithMany(c => c.CustomerDb)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("CustomerId");
            //       cs.MapRightKey("ClientId");
            //       cs.ToTable("ClientsToCustomers", "dbo");
            //   });
        }


        public DbSet<CustomerDb> Customers { get; set; }

        public DbSet<ClientDb> Clients { get; set; }
    }
}

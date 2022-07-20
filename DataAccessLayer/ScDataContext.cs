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


        DbSet<CustomerDb> Customers { get; set; }

        DbSet<ClientsDb> Clients { get; set; }
    }
}

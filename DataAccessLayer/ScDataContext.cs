using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class ScDataContext : DbContext
    {




        DbSet<CustomerDb> Customers { get; set; }

        DbSet<CustomerDb> Customers { get; set; }
    }
}

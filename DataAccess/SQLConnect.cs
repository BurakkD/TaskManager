using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public class SQLConnect:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PNBU9NR;Database=TaskManager;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Daily> Dailys { get; set; }
        public DbSet<Monthly> Monthlys { get; set; }
        public DbSet<Weekly> Weeklys { get; set; }

    }
}

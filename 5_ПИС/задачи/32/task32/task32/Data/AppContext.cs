using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task32.Data.DbModel;

namespace task32.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

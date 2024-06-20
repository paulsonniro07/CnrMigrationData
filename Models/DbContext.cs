using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrMigrationData.Models
{
    public class myDbContext : DbContext
    {
        public myDbContext() : base("name=DefaultConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<myDbContext, CnrMigrationData.Migrations.Configuration>());
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Vendor> Vendor { get; set; }
    }
}

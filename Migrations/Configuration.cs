using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrMigrationData.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CnrMigrationData.Models.myDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            // Register the custom SQL generator for SQLite
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace Ejercicio02.AccountManager.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Ejercicio02.AccountManager.DAL.EntityFramework.AccountManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Ejercicio02.AccountManager.DAL.EntityFramework.AccountManagerDbContext";
        }

        protected override void Seed(Ejercicio02.AccountManager.DAL.EntityFramework.AccountManagerDbContext pContext)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
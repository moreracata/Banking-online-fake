namespace Online_Banking.Migrations
{
    using Online_Banking.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Online_Banking.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Online_Banking.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.TypeAccounts.AddOrUpdate(new TypeAccount() { TypeCode = "1", TypeName = "Saving Account" });
            context.TypeAccounts.AddOrUpdate(new TypeAccount() { TypeCode = "2", TypeName = "Credit Account" });
            context.TypeAccounts.AddOrUpdate(new TypeAccount() { TypeCode = "3", TypeName = "Loans Account" });
        }
    }
}

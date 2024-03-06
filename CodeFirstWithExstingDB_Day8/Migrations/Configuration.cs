namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithExstingDB_Day8.CodefirstwithEstingDB_Day8>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstWithExstingDB_Day8.CodefirstwithEstingDB_Day8 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.cities.AddOrUpdate(a => a.city_name, new city() { city_name = "Mumbai" });

        }
    }
}

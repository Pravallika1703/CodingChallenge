namespace PeopleCodingChallange.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleCodingChallange.Models.PeopleConext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PeopleCodingChallange.Models.PeopleConext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.people.AddOrUpdate(
                p => p.PeopleID,

                new People { Name = "Andrew Peters", Age = 25, Address = "SLC", Interests = "Cooking" },
                new People { Name = "Brice Lambson", Age = 40, Address = "SLC", Interests = "Singing" }


                );
        }
    }
}

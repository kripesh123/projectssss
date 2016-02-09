namespace Consultancy.Application.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Consultancy.Application.Context.AbcDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Consultancy.Application.Context.AbcDbContext context)
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
            List<Consultancies> cList = new List<Consultancies>()
            {
                new Consultancies()
                {
                    Name="Xyz Pvt.Ltd.",
                    Description="Hello",
                    Logo="Logo.png",
                    Address="ktm",
                    City="ktm",
                    State="ktm",
                    lng=86.7333,
                    lat=26.333,
                    AddedDate= DateTime.Now,
                    ModifiedDate= null,
                    DeleteDate= null,
                    Status=true
                },

                new Consultancies()
                {
                    Name="PQR Pvt.Ltd.",
                    Description="Hi",
                    Logo="Logo1.png",
                    Address="ktm",
                    City="ktm",
                    State="ktm",
                    lng=86.333,
                    lat=26.7333,
                    AddedDate= DateTime.Now,
                    ModifiedDate= null,
                    DeleteDate= null,
                    Status=true

                }
            };
            cList.ForEach(p =>
            {
                context.Consultancies.Add(p);
                context.SaveChanges();
            });
        }
    }
}

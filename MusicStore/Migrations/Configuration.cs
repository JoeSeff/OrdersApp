namespace OrderApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OrderApp.Models.OrderAppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OrderApp.Models.OrderAppDataContext";
        }

        protected override void Seed(OrderApp.Models.OrderAppDataContext context)
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

            //SELECT TOP 1000[CustomerID]
            //  ,[FirstName]
            //  ,[LastName]
            //  ,[Sex]
            //  ,[DateofBirth]
            //  ,[Address]
            //  ,[State]
            //  ,[Street]
            //  ,[MobileNo]
            //  ,[PhoneNo]
            //  ,[CreatedOn]                  
            //FROM[OrderApp_003].[dbo].[Customers]

        //context.Customers.AddOrUpdate(
        //        p => p.CustomerID,
        //        new Customers { FirstName = "George", LastName = "Banks", Sex = "M",
        //            DateofBirth = DateTime.Now, Address = "1234", MobileNo="0711 222 333",
        //            State="Nrb", Street="", PhoneNo="12932423", CreatedOn = DateTime.Now }
        //    );

            //new Customers { FirstName = "George", LastName = "McKenzie", Sex = "M", CreatedOn = DateTime.Now },
            //new Customers { FirstName = "Sandra", LastName = "Bullock", Sex = "F", CreatedOn = DateTime.Now },
            //new Customers { FirstName = "Annie", LastName = "Banks", Sex = "F", CreatedOn = DateTime.Now },
            //new Customers { FirstName = "Jerry", LastName = "McGuire", Sex = "M", CreatedOn = DateTime.Now }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Models
{
	public class OrderAppDataContextInitializer : DropCreateDatabaseAlways<OrderAppDataContext>
	{
		protected override void Seed(OrderAppDataContext context)
		{
            context.Customers.AddOrUpdate(
                p => p.CustomerID,
                new Customers
                {
                    FirstName = "George",
                    LastName = "Banks",
                    Sex = "M",
                    DateofBirth = DateTime.Now,
                    Address = "1234",
                    MobileNo = "0711 222 333",
                    State = "Nrb",
                    Street = "",
                    PhoneNo = "12932423",
                    CreatedOn = DateTime.Now
                }
            );
            context.SaveChanges();
        }
	}
}

using System.Data.Entity;

namespace OrderApp.Models
{
	public class OrderAppDataContext : DbContext
	{
		//public DbSet<Artist> Artists { get; set; }
		//public DbSet<Album> Albums { get; set; }
		//public DbSet<ArtistDetails> ArtistDetails { get; set; }

        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class Orders
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [Column(Order = 1)]
        public int ProductID { get; set; }
        public Products products { get; set; }

        [Column(Order = 2)]
        public int CustomerID { get; set; }
        public Customers customers { get; set; }

        [Column(Order = 3)]
        public int Qty { get; set; }

        [Column(TypeName = "MONEY", Order = 4)]
        public decimal OrderTotal { get; set; }

        [Column(TypeName = "MONEY", Order = 5)]
        public decimal UnitPrice { get; set; }

        [Column("OrderDate", TypeName = "DateTime2", Order = 6)]
        public DateTime? OrderDate { get; set; }
        
    }
}
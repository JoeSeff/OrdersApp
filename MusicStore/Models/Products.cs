using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class Products
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Column(TypeName = "VARCHAR", Order = 1)]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Column(TypeName = "VARCHAR", Order = 2)]
        [MaxLength(255)]
        public string ProductDescritpion { get; set; }

        [Column(TypeName = "MONEY", Order = 3)]
        public decimal UnitPrice { get; set; }

        public int size { get; set; }

        [Column("CreatedOn", TypeName = "DateTime2", Order = 4)]
        public DateTime? CreatedOn { get; set; }

        // Foreign Keys
        public ICollection<Orders> Orders { get; set; }
        
    }
}
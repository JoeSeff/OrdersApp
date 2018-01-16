using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class Customers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Column(TypeName = "VARCHAR", Order = 1)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR", Order = 2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR", Order = 3)]
        [MaxLength(50)]
        public string Sex { get; set; }

        [Column("DateofBirth", TypeName = "DateTime2", Order = 4)]
        public DateTime? DateofBirth { get; set; }

        [Column(TypeName = "VARCHAR", Order = 5)]
        [MaxLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR", Order = 6)]
        [MaxLength(50)]
        public string State { get; set; }

        [Column(TypeName = "VARCHAR", Order = 7)]
        [MaxLength(50)]
        public string Street { get; set; }

        [Column(TypeName = "VARCHAR", Order = 8)]
        [MaxLength(15)]
        public string MobileNo { get; set; }

        [Column(TypeName = "VARCHAR", Order = 9)]
        [MaxLength(15)]
        public string PhoneNo { get; set; }

        [Column("CreatedOn", TypeName = "DateTime2", Order = 10)]
        public DateTime? CreatedOn { get; set; }

        // Foreign Keys
        public ICollection<Orders> Orders { get; set; }
        
    }
}
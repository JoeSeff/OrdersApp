using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class Users
    {
        [Key]
        [Column(Order = 0)]
        public int UserID { get; set; }

        [Column(TypeName = "VARCHAR", Order = 1)]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Column(TypeName = "VARCHAR", Order = 2)]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "VARCHAR", Order = 3)]
        [MaxLength(15)]
        public string PhoneNo { get; set; }

        [Column(TypeName = "VARCHAR", Order = 4)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Column("CreatedOn", TypeName = "DateTime2", Order = 5)]
        public DateTime CreatedOn { get; set; }
        
    }
}
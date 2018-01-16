using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp.Models
{
    public class ProductCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryID { get; set; }

        [Column(TypeName = "VARCHAR", Order = 1)]
        [MaxLength(50, ErrorMessage = "Category name cannot be more than 50 characters")]
        public string Category { get; set; }

        [Column("CreatedOn", TypeName = "DateTime2", Order = 2)]
        public DateTime? CreatedOn { get; set; }

        // Foreign Keys
        public ICollection<Products> Products { get; set; }
        
    }
}
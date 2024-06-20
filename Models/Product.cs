using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrMigrationData.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int product_id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string product_code { get; set; }

        [Required]
        public string product_name { get; set; }

        [Required]
        public decimal cost_price { get; set; }

        [Required]
        public decimal sell_price { get; set; }

        [Required]
        public int product_qty { get; set; }

        public string product_status { get; set; }

        // Navigation property for the related Vendor
        public int? VendorId { get; set; } // Foreign key
        public Vendor Vendor { get; set; } // Navigation property
    }
}

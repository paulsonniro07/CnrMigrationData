using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrMigrationData.Models
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int vendor_id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string vendor_code { get; set; }

        [Required]
        public string vendor_name { get; set; }

        public string vendor_status { get; set; }

    }
}

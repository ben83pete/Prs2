using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace prs.Models {
    public class Product {
                
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string PartNumber { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [StringLength (30)]
        [Required]
        public string Unit { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Price { get; set; }

        public bool Active { get; set; } = true;
                
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }


        public Product() {
                
        }
    }
}

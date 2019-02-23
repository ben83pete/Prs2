using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models {
    public class Vendors {

        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(5)]
        public string Zipcode { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        public bool IsPreferred { get; set; } = true;
        public bool Active { get; set; } = true;


        public Vendors() {

        }
    }
}

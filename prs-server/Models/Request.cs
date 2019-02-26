using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models {
    public class Request {

        public int Id { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(75)]
        public string Justification { get; set; }

        [StringLength(30)]
        public string Reject_Reason { get; set; }

        [StringLength(30)]
        public string Delivery_Mode { get; set; }

        public DateTime? SubmitDate { get; set; } = DateTime.Now;

        [StringLength(15)]
        public string Status { get; set; } = "NEW";

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Total { get; set; }

        public bool Active { get; set; } = true;

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Request_Lines> RequestLines { get; set; }



        public Request() {

        }
    }
}

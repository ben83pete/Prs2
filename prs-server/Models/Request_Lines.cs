using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models {
    public class Request_Lines {

        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }
       
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public int Qty { get; set; } = 1;

        public bool Active { get; set; } = true;


        public Request_Lines() {

        }
    }
}

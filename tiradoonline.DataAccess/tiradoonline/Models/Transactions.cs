using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTransactions
    {
        public int TransactionID { get; set; }

        public int UserID { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        public string Active { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Banking> Banking { get; set; }

        //public virtual Users Users { get; set; }
    }
}

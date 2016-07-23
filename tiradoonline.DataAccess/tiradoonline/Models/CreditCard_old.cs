using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCreditCard_old
    {
        public int CCID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string CCName { get; set; }

        
        public decimal CCLimit { get; set; }

        
        public DateTime CCExpiration { get; set; }

        
        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<CCBalance> CCBalance { get; set; }

        //public virtual Users Users { get; set; }
    }
}

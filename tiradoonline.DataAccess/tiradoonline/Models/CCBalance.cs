using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCCBalance
    {
        public int CCBalanceID { get; set; }

        public int CCID { get; set; }

        
        public DateTime CCDate { get; set; }

        [Required]
        [StringLength(100)]
        public string CCDescription { get; set; }

        
        public decimal CCPayment { get; set; }

        
        public DateTime update_dt { get; set; }

        //public virtual CreditCard_old CreditCard_old { get; set; }
    }
}

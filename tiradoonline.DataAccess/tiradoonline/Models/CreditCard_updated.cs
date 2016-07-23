using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCreditCard_updated
    {
        
        public int CreditCardID { get; set; }
        public int UserID { get; set; }

        [StringLength(50)]
        public string CreditCardName { get; set; }

        public decimal CreditLimit { get; set; }

        
        public decimal? MinimumPayment { get; set; }

        
        public decimal? CreditAvailable { get; set; }

        public byte? ClosingDate { get; set; }

        public byte? DueDate { get; set; }

        
        public decimal? Percentage { get; set; }

        
        public decimal? Payments { get; set; }

        
        public DateTime create_dt { get; set; }
    }
}

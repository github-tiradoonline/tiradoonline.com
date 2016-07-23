using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCreditCard_deleted
    {
        
        //[Column(Order = 0)]
        
        public int CreditCardID { get; set; }

        
        //[Column(Order = 1)]
        
        public int UserID { get; set; }

        
        //[Column(Order = 2)]
        [StringLength(50)]
        public string CreditCardName { get; set; }

        
        //[Column(Order = 3, TypeName = "numeric")]
        public decimal CreditLimit { get; set; }

        
        public decimal? MinimumPayment { get; set; }

        
        public decimal? CreditAvailable { get; set; }

        public byte? ClosingDate { get; set; }

        public byte? DueDate { get; set; }

        
        public decimal? Percentage { get; set; }

        
        public decimal? Payments { get; set; }

        
        //[Column(Order = 4)]
        public DateTime create_dt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCreditCardPayment
    {
        public int CreditCardPaymentID { get; set; }

        public int CreditCardID { get; set; }

        public DateTime CreditCardPaymentDate { get; set; }

        public decimal CreditCardPaymentAmount { get; set; }

        [StringLength(5000)]
        public string CreditCardPaymentComment { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual CreditCard CreditCard { get; set; }
    }
}

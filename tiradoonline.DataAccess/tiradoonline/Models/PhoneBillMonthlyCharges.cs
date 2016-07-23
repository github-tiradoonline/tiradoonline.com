using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillMonthlyCharges
    {
        public int PhoneBillMonthlyChargesID { get; set; }

        public int PhoneBillPhoneBillAccountID { get; set; }

        [Required]
        [StringLength(100)]
        public string MonthlyChargeName { get; set; }

        
        public decimal MonthlyChargeValue { get; set; }

        public DateTime create_dt { get; set; }
    }
}

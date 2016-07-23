using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillMonthlyDataCharges
    {
        public int PhoneBillMonthlyDataChargesID { get; set; }

        public int PhoneBillPhoneBillAccountID { get; set; }

        
        public decimal MonthlyDataChargeAmount { get; set; }

        public int MonthlyDataChargeMaxMB { get; set; }

        public int MonthlyDataChargeUsedMB { get; set; }

        public DateTime create_dt { get; set; }
    }
}

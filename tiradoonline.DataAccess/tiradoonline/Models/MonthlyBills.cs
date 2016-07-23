using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMonthlyBills
    {
        public int MonthlyBillID { get; set; }
        public int BankingAccountID { get; set; }
        public DateTime MonthlyBillStartDate { get; set; }
        public DateTime MonthlyBillDate { get; set; }

        [Required]
        [StringLength(100)]
        public string MonthlyBillDesc { get; set; }

        public decimal MonthlyBillAmount { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual BankingAccount BankingAccount { get; set; }
    }
}

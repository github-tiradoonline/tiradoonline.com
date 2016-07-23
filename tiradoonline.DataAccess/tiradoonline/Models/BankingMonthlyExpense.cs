using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingMonthlyExpense
    {
        public int BankingMonthlyExpenseID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string BankingMonthlyExpenseName { get; set; }

        
        public decimal BankingMonthlyExpenseAmount { get; set; }

        public byte BankingMonthlyExpenseBillDate { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class modelBankingMonthlyExpense_deleted
    {
        
        //[Column(Order = 0)]
        
        public int BankingMonthlyExpenseID { get; set; }

        
        //[Column(Order = 1)]
        
        public int UserID { get; set; }

        
        //[Column(Order = 2)]
        [StringLength(100)]
        public string BankingMonthlyExpenseName { get; set; }

        
        //[Column(Order = 3, TypeName = "numeric")]
        public decimal BankingMonthlyExpenseAmount { get; set; }

        
        //[Column(Order = 4)]
        public byte BankingMonthlyExpenseBillDate { get; set; }

        
        //[Column(Order = 5)]
        public DateTime create_dt { get; set; }
    }
}

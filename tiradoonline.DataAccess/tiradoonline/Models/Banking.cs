using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBanking
    {
        public int BankingID { get; set; }

        public int BankingAccountID { get; set; }

        public int? SubBankingAccountID { get; set; }

        public int TransactionID { get; set; }

        
        public DateTime BankingDate { get; set; }

        
        public decimal Payment { get; set; }

        public bool BankingFile { get; set; }

        [StringLength(200)]
        public string BankingFileName { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public bool Pending { get; set; }

        
        public DateTime update_dt { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual BankingAccount BankingAccount { get; set; }

        //public virtual Transactions Transactions { get; set; }
    }
}

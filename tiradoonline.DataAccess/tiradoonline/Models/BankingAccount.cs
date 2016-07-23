using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingAccount
    {
        public int BankingAccountID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string BankingAccountName { get; set; }

        public bool ReceiveEmails { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Banking> Banking { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<BankingAccountEmail> BankingAccountEmail { get; set; }

        
        //public virtual ICollection<BankingAccountLinked_old> BankingAccountLinked_old { get; set; }

        
        //public virtual ICollection<BankingAccountLinked> BankingAccountLinked { get; set; }

        
        //public virtual ICollection<MonthlyBills> MonthlyBills { get; set; }
    }
}

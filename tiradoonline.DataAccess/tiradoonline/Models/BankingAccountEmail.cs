using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingAccountEmail
    {
        public int BankingAccountEmailID { get; set; }

        public int BankingAccountID { get; set; }

        [Required]
        [StringLength(100)]
        public string BankingAccountEmail { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual BankingAccount BankingAccount { get; set; }
    }
}

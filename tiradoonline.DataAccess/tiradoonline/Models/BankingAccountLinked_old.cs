using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingAccountLinked_old
    {
        public int BankingAccountLinkedID { get; set; }

        public int BankingAccountID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual BankingAccount BankingAccount { get; set; }
    }
}

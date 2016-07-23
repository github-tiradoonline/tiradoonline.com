using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingAccountLinked
    {
        public int BankingAccountLinkedID { get; set; }

        public int BankingAccountID { get; set; }

        public int LinkedUserID { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual BankingAccount BankingAccount { get; set; }

        //public virtual Users Users { get; set; }
    }
}

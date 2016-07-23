using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillPhoneBillAccount
    {
        public int PhoneBillPhoneBillAccountID { get; set; }

        public int PhoneBillID { get; set; }

        public int PhoneBillAccountID { get; set; }

        public DateTime create_dt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBill
    {
        public int PhoneBillID { get; set; }

        public int PhoneBillPhoneBillAccountID { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneBillName { get; set; }

        public DateTime PhoneBillStartDate { get; set; }

        public DateTime PhoneBillEndDate { get; set; }

        public DateTime create_dt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillAccount
    {
        public int PhoneBillAccountID { get; set; }

        public int PhoneBProviderID { get; set; }

        public int PhoneDeviceID { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneBillAccountName { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneBillAccountPhoneNumber { get; set; }

        public DateTime create_dt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillProvider
    {
        public int PhoneBillProviderID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneBillProviderName { get; set; }

        public DateTime create_dt { get; set; }
    }
}
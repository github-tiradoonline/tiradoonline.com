using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCompanyPhoneCall
    {
        public int JobCompanyPhoneCallID { get; set; }

        public int JobCompanyID { get; set; }

        public int JobCompanyContactID { get; set; }

        public int JobCompanyPhoneCallTypeID { get; set; }

        public DateTime JobCompanyPhoneCallDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCompanyPhoneCallPhoneNumber { get; set; }

        [Required]
        public string JobCompanyPhoneCallNotes { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }

        //public virtual JobCompanyPhoneCallType JobCompanyPhoneCallType { get; set; }
    }
}

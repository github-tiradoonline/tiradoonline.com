using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCompanyPhoneCallType
    {
        public int JobCompanyPhoneCallTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCompanyPhoneCallType { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<JobCompanyPhoneCall> JobCompanyPhoneCall { get; set; }
    }
}

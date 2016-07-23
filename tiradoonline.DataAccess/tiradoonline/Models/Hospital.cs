using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelHospital
    {
        public int HospitalID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string HospitalName { get; set; }

        [Required]
        [StringLength(100)]
        public string HospitalAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string HospitalCity { get; set; }

        public int HospitalStateID { get; set; }

        [Required]
        [StringLength(20)]
        public string HospitalZipCode { get; set; }

        [Required]
        [StringLength(50)]
        public string HospitalPhone { get; set; }

        [Required]
        [StringLength(200)]
        public string HospitalWebsite { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual States States { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<HospitalStaff> HospitalStaff { get; set; }
    }
}

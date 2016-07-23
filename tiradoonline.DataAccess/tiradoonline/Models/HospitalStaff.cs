using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelHospitalStaff
    {
        public int HospitalStaffID { get; set; }

        public int UserID { get; set; }

        public int HospitalID { get; set; }

        public int HospitalPositionID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string Notes { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Hospital Hospital { get; set; }

        //public virtual HospitalPosition HospitalPosition { get; set; }
    }
}

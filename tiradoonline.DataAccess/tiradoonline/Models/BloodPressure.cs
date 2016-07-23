using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBloodPressure
    {
        public int BloodPressureID { get; set; }

        public int UserID { get; set; }

        public DateTime BloodPressureDateTime { get; set; }

        public short BloodPressureTop { get; set; }

        public short BloodPressureBottom { get; set; }

        [StringLength(2000)]
        public string BloodPressureComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

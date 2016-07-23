using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelHeartRate
    {
        public int HeartRateID { get; set; }

        public int UserID { get; set; }

        public DateTime HeartRateDateTime { get; set; }

        public short HeartRate { get; set; }

        [StringLength(2000)]
        public string HeartRateComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        //public virtual Users Users1 { get; set; }
    }
}

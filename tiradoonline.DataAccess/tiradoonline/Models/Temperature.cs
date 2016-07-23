using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTemperature
    {
        public int TemperatureID { get; set; }

        public int UserID { get; set; }

        public DateTime TemperatureDateTime { get; set; }

        public decimal Temperature { get; set; }

        [StringLength(2000)]
        public string TemperatureComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

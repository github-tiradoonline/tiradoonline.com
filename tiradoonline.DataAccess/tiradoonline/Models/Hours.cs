using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelHours
    {
        public int HoursID { get; set; }

        public int CompanyID { get; set; }

        public DateTime WorkDate { get; set; }

        
        public decimal StartHour { get; set; }

        
        public decimal? EndHour { get; set; }

        
        public decimal? LunchHour { get; set; }

        //public virtual Companies Companies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobEmail
    {
        public int JobEmailID { get; set; }

        public int JobID { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Jobs Jobs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelOxygen
    {
        public int OxygenID { get; set; }

        public int UserID { get; set; }

        public DateTime OxygenDateTime { get; set; }

        public short Oxygen { get; set; }

        [StringLength(2000)]
        public string OxygenComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

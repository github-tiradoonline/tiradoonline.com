using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelInsulin
    {
        public int InsulinID { get; set; }

        public int UserID { get; set; }

        public int MedicineID { get; set; }

        public DateTime InsulinDateTime { get; set; }

        
        public decimal Units { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

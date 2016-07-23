using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMedicineDose
    {
        public int MedicineDoseID { get; set; }

        public int MedicineID { get; set; }

        public DateTime MedicineDoseDateTime { get; set; }

        [StringLength(2000)]
        public string MedicineDoseDescription { get; set; }

        
        public decimal? Amount { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Medicine Medicine { get; set; }
    }
}

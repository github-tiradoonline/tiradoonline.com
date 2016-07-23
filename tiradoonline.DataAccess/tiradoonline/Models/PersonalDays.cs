using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPersonalDays
    {
        
        public int PersonalDayID { get; set; }

        public int CompanyID { get; set; }

        
        public DateTime PersonalDate { get; set; }

        
        public DateTime create_dt { get; set; }

        //public virtual Companies Companies { get; set; }
    }
}

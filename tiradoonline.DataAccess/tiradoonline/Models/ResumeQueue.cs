using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeQueue
    {
        public int ResumeQueueID { get; set; }

        public int CompanyID { get; set; }

        public bool Status { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }
    }
}

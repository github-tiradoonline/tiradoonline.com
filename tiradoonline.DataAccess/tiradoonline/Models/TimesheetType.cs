using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTimesheetType
    {
        public int TimesheetTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string TimesheetType { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual ICollection<Timesheet> Timesheet { get; set; }
    }
}

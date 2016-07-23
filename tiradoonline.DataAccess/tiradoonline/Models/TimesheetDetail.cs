using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTimesheetDetail
    {
        public int TimesheetDetailID { get; set; }

        public int TimesheetID { get; set; }

        public DateTime TimesheetDetailDate { get; set; }

        
        public decimal TimesheetHours { get; set; }

        [Required]
        [StringLength(2000)]
        public string TimesheetDescription { get; set; }

        public bool TimesheetBillable { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Timesheet Timesheet { get; set; }
    }
}

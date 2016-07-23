using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTimesheetCompany
    {
        public int TimeSheetCompanyID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string TimesheetCompanyName { get; set; }

        [StringLength(100)]
        public string TimesheetCompanyAddress1 { get; set; }

        [StringLength(100)]
        public string TimesheetCompanyAddress2 { get; set; }

        [StringLength(100)]
        public string TimesheetCompanyCity { get; set; }

        public int? TimesheetCompanyStateID { get; set; }

        [StringLength(20)]
        public string TimesheetCompanyZipCode { get; set; }

        [StringLength(50)]
        public string TimesheetCompanyPhone { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Timesheet> Timesheet { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<TimesheetPayment> TimesheetPayment { get; set; }
    }
}

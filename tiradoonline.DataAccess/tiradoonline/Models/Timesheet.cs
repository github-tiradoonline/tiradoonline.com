using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTimesheet
    {
        public int TimesheetID { get; set; }

        public int TimesheetCompanyID { get; set; }

        public int TimesheetTypeID { get; set; }

        public DateTime TimesheetInvoiceDate { get; set; }

        [Required]
        [StringLength(50)]
        public string TimesheetInvoiceNumber { get; set; }

        
        public decimal TimesheetHourlyRate { get; set; }

        public DateTime TimesheetStartDate { get; set; }

        public DateTime TimesheetEndDate { get; set; }

        public string TimesheetHTML { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual TimesheetCompany TimesheetCompany { get; set; }

        //public virtual TimesheetType TimesheetType { get; set; }

        
        //public virtual ICollection<TimesheetDetail> TimesheetDetail { get; set; }
    }
}

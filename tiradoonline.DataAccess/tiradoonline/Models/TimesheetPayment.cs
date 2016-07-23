using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTimesheetPayment
    {
        
        public int TimesheetPaymentID { get; set; }

        public int TimesheetCompanyID { get; set; }

        public DateTime TimesheetPaymentDate { get; set; }

        public decimal TimesheetPayment { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual TimesheetCompany TimesheetCompany { get; set; }
    }
}

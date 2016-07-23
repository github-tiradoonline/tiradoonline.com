using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPaychecks
    {
        
        public int PaycheckID { get; set; }

        public int? TimesheetCompanyID { get; set; }

        public DateTime PaymentDate { get; set; }

        
        public decimal HourlyRate { get; set; }

        
        public decimal Gross { get; set; }

        
        public decimal? Federal { get; set; }

        
        public decimal? SocialSecurity { get; set; }

        
        public decimal? Medicare { get; set; }

        
        public decimal? NY_Withholding { get; set; }

        
        public decimal? NY_Disability { get; set; }

        
        public decimal? NY_City { get; set; }

        public string Notes { get; set; }

        public DateTime create_dt { get; set; }
    }
}

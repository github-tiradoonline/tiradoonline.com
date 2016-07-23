using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobInterview
    {
        public int JobInterviewID { get; set; }

        public int JobCompanyID { get; set; }

        public int JobInterviewTypeID { get; set; }

        public int JobInterviewClientID { get; set; }

        public int JobInterviewClientContactID { get; set; }

        public DateTime JobInterviewDateTime { get; set; }

        [StringLength(50)]
        public string JobInterviewAddress1 { get; set; }

        [StringLength(50)]
        public string JobInterviewAddress2 { get; set; }

        [StringLength(50)]
        public string JobInterviewCity { get; set; }

        public int? StateID { get; set; }

        [StringLength(20)]
        public string JobInterviewZipCode { get; set; }

        [Required]
        public string JobInterviewNotes { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }


        //public virtual JobInterviewType JobInterviewType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobs
    {
        public int JobID { get; set; }
        public int JobCompanyID { get; set; }
        public int JobCompanyContactID { get; set; }
        public int JobSalaryTypeID { get; set; }

        public DateTime JobDate { get; set; }

        [Required]
        [StringLength(500)]
        public string JobPosition { get; set; }

        public decimal JobSalary { get; set; }

        [StringLength(100)]
        public string JobClient { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCity { get; set; }

        public int JobStateID { get; set; }

        [Required]
        public string JobRequirements { get; set; }

        public string JobNotes { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }

        //public virtual JobCompanyContact JobCompanyContact { get; set; }

        
        //public virtual ICollection<JobEmail> JobEmail { get; set; }

        
        //public virtual ICollection<JobQueue> JobQueue { get; set; }
    }
}

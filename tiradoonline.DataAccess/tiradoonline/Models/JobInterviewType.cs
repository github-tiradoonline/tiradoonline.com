using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobInterviewType
    {
        public int JobInterviewTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string JobInterviewType { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<JobInterview> JobInterview { get; set; }
    }
}

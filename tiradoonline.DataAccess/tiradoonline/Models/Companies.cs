using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCompanies
    {
        public int CompanyID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        
        public DateTime? StartDate { get; set; }

        
        public DateTime? EndDate { get; set; }

        
        //public virtual ICollection<Hours> Hours { get; set; }

        
        //public virtual ICollection<PersonalDays> PersonalDays { get; set; }

        
        //public virtual ICollection<SickDays> SickDays { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobSalaryType
    {
        public int JobSalaryTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string JobSalaryType { get; set; }

        public DateTime create_dt { get; set; }
    }
}

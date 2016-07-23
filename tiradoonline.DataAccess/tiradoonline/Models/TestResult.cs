using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTestResult
    {
        public int TestResultID { get; set; }

        [Required]
        [StringLength(20)]
        public string TestResultName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Test> Test { get; set; }
    }
}

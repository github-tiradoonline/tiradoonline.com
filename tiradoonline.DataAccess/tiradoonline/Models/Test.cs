using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTest
    {
        public int TestID { get; set; }

        public int UserID { get; set; }

        public int TestTypeID { get; set; }

        public int TestResultID { get; set; }

        
        public DateTime TestDate { get; set; }

        [Required]
        [StringLength(50)]
        public string TestLocation { get; set; }

        [StringLength(200)]
        public string TestComments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual TestResult TestResult { get; set; }

        //public virtual TestType TestType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTestType
    {
        public int TestTypeID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string TestTypeName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Test> Test { get; set; }

        //public virtual Users Users { get; set; }
    }
}

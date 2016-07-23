using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryDrugTestType
    {
        public int RecoveryDrugTestTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string RecoveryDrugTestName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<RecoveryDrugTest> RecoveryDrugTest { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryDrugTest
    {
        public int RecoveryDrugTestID { get; set; }

        public int RecoveryProgramID { get; set; }

        public int RecoveryDrugTestTypeID { get; set; }

        public DateTime RecoveryDrugTestDateTime { get; set; }

        public bool RecoveryDrugTestResult { get; set; }

        [StringLength(1000)]
        public string RecoveryDrugTestDescription { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual RecoveryDrugTestType RecoveryDrugTestType { get; set; }

        //public virtual RecoveryPrograms RecoveryPrograms { get; set; }
    }
}

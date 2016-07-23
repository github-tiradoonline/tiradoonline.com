using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryPrograms
    {
        public int RecoveryProgramID { get; set; }

        public int? UserID { get; set; }

        public int RecoveryTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramName { get; set; }

        public DateTime? start_dt { get; set; }

        public DateTime? end_dt { get; set; }

        public DateTime? sober_dt { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<RecoveryCounselors> RecoveryCounselors { get; set; }

        
        //public virtual ICollection<RecoveryDrugTest> RecoveryDrugTest { get; set; }

        
        //public virtual ICollection<RecoveryGroups> RecoveryGroups { get; set; }

        //public virtual RecoveryTypes RecoveryTypes { get; set; }

        //public virtual Users Users { get; set; }
    }
}

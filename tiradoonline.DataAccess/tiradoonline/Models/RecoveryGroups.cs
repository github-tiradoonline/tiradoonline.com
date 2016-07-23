using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryGroups
    {
        public int RecoveryGroupID { get; set; }

        public int RecoveryProgramID { get; set; }

        [Required]
        [StringLength(50)]
        public string RecoveryGroupName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<RecoveryGroupSessions> RecoveryGroupSessions { get; set; }

        //public virtual RecoveryPrograms RecoveryPrograms { get; set; }

        
        //public virtual ICollection<RecoveryGroupSessions> RecoveryGroupSessions1 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryGroupSessions
    {
        public int RecoveryGroupSessionID { get; set; }

        public int RecoveryGroupID { get; set; }

        public int RecoveryCounselorID { get; set; }

        public DateTime RecoveryGroupSessionDateTime { get; set; }

        public bool ScheduledGroup { get; set; }

        [StringLength(2000)]
        public string Comments { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual RecoveryGroups RecoveryGroups { get; set; }

        //public virtual RecoveryGroups RecoveryGroups1 { get; set; }
    }
}

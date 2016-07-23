using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryCounselors
    {
        
        public int RecoveryCounselorID { get; set; }

        public int RecoveryProgramID { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual RecoveryPrograms RecoveryPrograms { get; set; }
    }
}

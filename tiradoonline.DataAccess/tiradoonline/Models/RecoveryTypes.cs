using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelRecoveryTypes
    {
        public int RecoveryTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string RecoveryTypeName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<RecoveryPrograms> RecoveryPrograms { get; set; }
    }
}

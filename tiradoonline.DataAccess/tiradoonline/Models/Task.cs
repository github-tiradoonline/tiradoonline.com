using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTask
    {
        public int TaskID { get; set; }

        public int TaskProjectID { get; set; }

        public DateTime TaskDate { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskName { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? TaskDueDate { get; set; }

        public string TaskDescription { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual TaskProject TaskProject { get; set; }
    }
}

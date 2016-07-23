using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTaskProject
    {
        public int TaskProjectID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskProjectName { get; set; }

        [Required]
        public string TaksProjectDescription { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Task> Task { get; set; }

        //public virtual Users Users { get; set; }
    }
}

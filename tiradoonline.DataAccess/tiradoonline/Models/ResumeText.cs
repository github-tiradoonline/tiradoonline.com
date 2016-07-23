using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeText
    {
        public int ResumeTextID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string ResumeTextName { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

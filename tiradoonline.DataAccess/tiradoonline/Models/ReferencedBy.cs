using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelReferencedBy
    {
        public int ReferencedByID { get; set; }

        public int UserID { get; set; }

        public int OrderNum { get; set; }

        [Required]
        [StringLength(20)]
        public string ReferencedByName { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<ResumeDownloads> ResumeDownloads { get; set; }
    }
}

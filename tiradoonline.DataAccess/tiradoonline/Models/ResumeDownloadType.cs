using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeDownloadType
    {
        public int ResumeDownloadTypeID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string ResumeDownloadTypeName { get; set; }

        [Required]
        [StringLength(100)]
        public string ResumeDownloadTypeFileName { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

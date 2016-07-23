using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeDownloads
    {
        
        public int ResumeDownloadID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        public int ReferencedByID { get; set; }

        public int ResumeDownloadTypeID { get; set; }

        [StringLength(1000)]
        public string Referer { get; set; }

        [Required]
        [StringLength(50)]
        public string SessionID { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual ReferencedBy ReferencedBy { get; set; }
    }
}

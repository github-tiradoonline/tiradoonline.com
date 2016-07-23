using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeFile
    {
        public int ResumeFileID { get; set; }

        public int UserID { get; set; }

        public string CoverLetterText { get; set; }

        public string ResumeText { get; set; }

        public string CoverLetterHTML { get; set; }

        public string ResumeHTML { get; set; }

        [StringLength(500)]
        public string ResumeFileName { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

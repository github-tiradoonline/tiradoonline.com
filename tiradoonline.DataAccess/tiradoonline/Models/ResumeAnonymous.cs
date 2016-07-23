using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelResumeAnonymous
    {
        public int ResumeAnonymousID { get; set; }

        [StringLength(100)]
        public string SessionID { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        [StringLength(500)]
        public string Browser { get; set; }

        [StringLength(500)]
        public string Referer { get; set; }

        [StringLength(50)]
        public string ResumeFile { get; set; }

        public DateTime create_dt { get; set; }
    }
}

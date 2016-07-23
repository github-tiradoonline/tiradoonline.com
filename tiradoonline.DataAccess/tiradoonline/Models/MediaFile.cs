using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMediaFile
    {
        public int MediaFileID { get; set; }

        public int UserID { get; set; }

        [Required]
        public string MediaFileDirectory { get; set; }

        [Required]
        public string MediaFileName { get; set; }

        [StringLength(100)]
        public string MediaFileExt { get; set; }

        [StringLength(100)]
        public string MediaFileURL { get; set; }

        public string ErrorMessage { get; set; }
        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

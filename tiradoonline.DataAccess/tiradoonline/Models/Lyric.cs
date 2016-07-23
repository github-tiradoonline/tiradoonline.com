using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelLyric
    {
        public int LyricID { get; set; }

        public int UserID { get; set; }

        public int LyricTypeID { get; set; }

        [Required]
        [StringLength(1000)]
        public string LyricName { get; set; }

        [Required]
        [StringLength(100)]
        public string LyricActorArtist { get; set; }

        [Required]
        public string LyricContent { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual LyricType LyricType { get; set; }

        //public virtual Users Users { get; set; }
    }
}

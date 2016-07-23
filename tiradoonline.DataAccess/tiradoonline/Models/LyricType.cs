using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelLyricType
    {
        public int LyricTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string LyricTypeName { get; set; }

        [Required]
        [StringLength(50)]
        public string LyricCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string LyricPersonType { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Lyric> Lyric { get; set; }
    }
}

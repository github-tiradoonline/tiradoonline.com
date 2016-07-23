using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMovies
    {
        public int MovieID { get; set; }

        public int UserID { get; set; }

        public int GenreID { get; set; }

        [Required]
        [StringLength(200)]
        public string MovieTitle { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Artists> Artists { get; set; }

        //public virtual Genre Genre { get; set; }

        //public virtual Users Users { get; set; }
    }
}

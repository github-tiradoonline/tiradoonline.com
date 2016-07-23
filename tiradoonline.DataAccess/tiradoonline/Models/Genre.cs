using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelGenre
    {
        public int GenreID { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Movies> Movies { get; set; }
    }
}

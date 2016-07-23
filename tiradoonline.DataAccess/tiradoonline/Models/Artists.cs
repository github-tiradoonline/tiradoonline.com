using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelArtists
    {
        
        public int ArtistID { get; set; }

        public int UserID { get; set; }

        public int? MovieID { get; set; }

        [Required]
        [StringLength(50)]
        public string ArtistFirstName { get; set; }

        [StringLength(50)]
        public string ArtistLastName { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Movies Movies { get; set; }

        //public virtual Users Users { get; set; }
    }
}

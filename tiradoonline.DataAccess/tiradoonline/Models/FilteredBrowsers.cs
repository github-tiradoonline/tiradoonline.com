using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelFilteredBrowsers
    {
        public int FilteredBrowserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [Required]
        [StringLength(500)]
        public string Browser { get; set; }

        public DateTime create_dt { get; set; }
    }
}

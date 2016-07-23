using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCountries
    {
        
        public int CountryID { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryAbbr { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        public string Country { get; set; }

        public string ErrorMessage { get; set; }
        public DateTime create_dt { get; set; }
    }
}

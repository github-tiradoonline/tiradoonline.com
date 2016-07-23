using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelFilteredIPAddresses
    {
        
        public int FilteredIPAddressID { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [Required]
        [StringLength(20)]
        public string IPAddress { get; set; }

        public DateTime create_dt { get; set; }
    }
}

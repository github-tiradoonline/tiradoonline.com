using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelAreaCodes
    {
        public int AreaCodeID { get; set; }

        public int AreaCode { get; set; }

        public int? StateID { get; set; }

        [Required]
        [StringLength(255)]
        public string Region { get; set; }
    }
}

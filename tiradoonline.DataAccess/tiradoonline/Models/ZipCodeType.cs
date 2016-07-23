using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelZipCodeType
    {
        public int ZipCodeTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string ZipCodeTypeName { get; set; }

        public DateTime create_dt { get; set; }
    }
}

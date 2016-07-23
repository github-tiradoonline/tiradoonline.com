using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelZipCode
    {
        public int ZipCodeID { get; set; }

        public double? Zipcode { get; set; }

        public int ZipCodeTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        public string State { get; set; }
        public int StateID { get; set; }

        [StringLength(255)]
        public string LocationType { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        public bool Decommisioned { get; set; }

        [StringLength(255)]
        public string TaxReturnsFiled { get; set; }

        [StringLength(255)]
        public string EstimatedPopulation { get; set; }

        [StringLength(255)]
        public string TotalWages { get; set; }

        public string ErrorMessage { get; set; }

        public string TaxRate { get; set; }
    }
}

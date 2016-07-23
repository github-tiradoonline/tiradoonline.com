using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelTaxRate
    {
        public int TaxRateID { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        public double ZipCode { get; set; }

        [Required]
        [StringLength(100)]
        public string TaxRegionName { get; set; }

        [Required]
        [StringLength(100)]
        public string TaxRegionCode { get; set; }

        
        public decimal CombinedRate { get; set; }

        
        public decimal StateRate { get; set; }

        
        public decimal CountyRate { get; set; }

        
        public decimal CityRate { get; set; }

        
        public decimal SpecialRate { get; set; }
    }
}

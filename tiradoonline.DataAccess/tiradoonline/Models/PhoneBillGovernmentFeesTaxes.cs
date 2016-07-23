using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillGovernmentFeesTaxes
    {
        public int PhoneBillGovernmentFeesTaxesID { get; set; }

        public int PhoneBillPhoneBillAccountID { get; set; }

        
        public decimal? ServiceFee911 { get; set; }

        
        public decimal? CityDistrictSalesTax { get; set; }

        
        public decimal? CitySalesTax { get; set; }

        
        public decimal? LocalWireless911Surcharge { get; set; }

        
        public decimal? NYSalesTax { get; set; }

        public DateTime create_dt { get; set; }
    }
}

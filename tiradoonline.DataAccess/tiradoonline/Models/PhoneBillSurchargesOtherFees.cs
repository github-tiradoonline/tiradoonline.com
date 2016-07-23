using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPhoneBillSurchargesOtherFees
    {
        public int PhoneBillSurchargesOtherFeesID { get; set; }

        public int PhoneBillPhoneBillAccountID { get; set; }

        
        public decimal? AdministrativeFee { get; set; }

        
        public decimal? CountyGrossReceipts { get; set; }

        
        public decimal? FederalUniversalServiceCharge { get; set; }

        
        public decimal? MTATelecom { get; set; }

        
        public decimal? RegulartoryCostRecoveryCharge { get; set; }

        
        public decimal? StateTelecommunicationsExcise { get; set; }

        public DateTime create_dt { get; set; }
    }
}

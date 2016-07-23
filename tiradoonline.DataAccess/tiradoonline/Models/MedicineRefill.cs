using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMedicineRefill
    {
        public int MedicineRefillID { get; set; }

        public int MedicineID { get; set; }

        public int PharmacyID { get; set; }

        public int DoctorID { get; set; }

        public DateTime? RefillOrderDate { get; set; }

        public DateTime? RefillOrderPickupDate { get; set; }

        public DateTime? RefillDateFilled { get; set; }

        
        public decimal? RefillAmount { get; set; }

        
        public decimal? DailyAmount { get; set; }

        public int? RefillTimes { get; set; }

        public DateTime? RefillUntilDate { get; set; }

        public DateTime? RefillDiscardDate { get; set; }

        [Required]
        [StringLength(5000)]
        public string RefillDescription { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Doctor Doctor { get; set; }

        //public virtual Medicine Medicine { get; set; }

        //public virtual Pharmacy Pharmacy { get; set; }
    }
}

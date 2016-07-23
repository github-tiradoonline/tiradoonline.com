using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPharmacy
    {
        public int PharmacyID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string PharmacyName { get; set; }

        [Required]
        [StringLength(100)]
        public string PharmacyAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PharmacyCity { get; set; }

        public int PharmacyStateID { get; set; }

        [Required]
        [StringLength(20)]
        public string PharmacyZipCode { get; set; }

        [Required]
        [StringLength(20)]
        public string PharmacyTelephoneNumber { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<MedicineRefill> MedicineRefill { get; set; }

        //public virtual Users Users { get; set; }

        //public virtual Users Users1 { get; set; }

        //public virtual States States { get; set; }
    }
}

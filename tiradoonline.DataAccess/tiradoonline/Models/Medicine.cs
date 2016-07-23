using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMedicine
    {
        public int MedicineID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string MedicineName { get; set; }

        [Required]
        [StringLength(50)]
        public string GenericName { get; set; }

        [StringLength(30)]
        public string PrescriptionNumber { get; set; }

        public int UnitID { get; set; }

        public string MedicineDescription { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<MedicineDose> MedicineDose { get; set; }

        
        //public virtual ICollection<MedicineDosePackageItem> MedicineDosePackageItem { get; set; }

        
        //public virtual ICollection<MedicineRefill> MedicineRefill { get; set; }
    }
}

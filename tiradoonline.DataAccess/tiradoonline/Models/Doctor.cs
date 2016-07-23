using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelDoctor
    {

        public int DoctorID { get; set; }

        public int UserID { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string TelephoneNumber { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<MedicineRefill> MedicineRefill { get; set; }
    }
}

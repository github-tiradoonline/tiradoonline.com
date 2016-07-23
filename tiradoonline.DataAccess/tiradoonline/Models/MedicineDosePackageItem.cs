using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMedicineDosePackageItem
    {
        public int MedicineDosePackageItemID { get; set; }

        public int MedicineDosePackageID { get; set; }

        public int MedicineID { get; set; }

        
        public decimal Amount { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Medicine Medicine { get; set; }

        //public virtual MedicineDosePackage MedicineDosePackage { get; set; }
    }
}

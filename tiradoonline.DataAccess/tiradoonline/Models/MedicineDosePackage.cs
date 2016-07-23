using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMedicineDosePackage
    {
        public int MedicineDosePackageID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string MedicineDosePackageName { get; set; }

        public bool Active { get; set; }

        //[Column(TypeName = "date")]
        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<MedicineDosePackageItem> MedicineDosePackageItem { get; set; }
    }
}

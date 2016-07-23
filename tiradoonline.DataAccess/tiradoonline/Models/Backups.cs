using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBackups
    {
        
        //[Column(Order = 0)]
        public int BackupID { get; set; }

        
        //[Column(Order = 1)]
        
        public int UserID { get; set; }

        
        public DateTime BackupDate { get; set; }

        //public virtual Users Users { get; set; }

        //public virtual Users Users1 { get; set; }
    }
}

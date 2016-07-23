using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelLogins
    {
        
        public int LoginID { get; set; }
        public int UserID { get; set; }
        
        public DateTime LoginDate { get; set; }

        [StringLength(100)]
        public string Browser { get; set; }

        [Required]
        [StringLength(15)]
        public string IPAddress { get; set; }

        //public virtual Users Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelServerProject
    {
        public int ServerProjectID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string ServerProjectName { get; set; }

        public string ServerProjectNotes { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Server> Server { get; set; }

        //public virtual Users Users { get; set; }
    }
}

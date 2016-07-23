using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelServer
    {
        public int ServerID { get; set; }

        public int ServerProjectID { get; set; }

        [Required]
        [StringLength(50)]
        public string ServerName { get; set; }

        public string ServerNotes { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual ServerProject ServerProject { get; set; }

        
        //public virtual ICollection<ServerInformation> ServerInformation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSessions
    {
        
        public int SessionID { get; set; }

        [StringLength(50)]
        public string Session_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Application { get; set; }

        [Required]
        [StringLength(500)]
        public string SCRIPT_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(500)]
        public string Browser { get; set; }

        [StringLength(1000)]
        public string Referer { get; set; }

        public DateTime create_dt { get; set; }
    }
}

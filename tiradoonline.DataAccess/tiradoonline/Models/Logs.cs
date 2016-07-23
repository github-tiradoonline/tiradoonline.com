using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelLogs
    {
        public int LogID { get; set; }

        [Required]
        [StringLength(1000)]
        public string ApplicationName { get; set; }

        [Required]
        public string LogDesc { get; set; }

        public DateTime create_dt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelExecutedSQLScripts
    {
        public int ExecutedSQLScriptID { get; set; }

        [StringLength(100)]
        public string ApplicationName { get; set; }

        [Required]
        [StringLength(1000)]
        public string ExecutedSQLScript { get; set; }

        
        public DateTime create_dt { get; set; }
    }
}

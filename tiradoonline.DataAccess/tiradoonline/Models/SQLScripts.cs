using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSQLScripts
    {
        
        public int SQLScriptID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(1000)]
        public string SQLScript { get; set; }

        
        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        //public virtual Users Users1 { get; set; }

        //public virtual Users Users2 { get; set; }
    }
}

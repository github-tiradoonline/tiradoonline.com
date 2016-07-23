using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPageLogs
    {
        
        public int PageLogID { get; set; }

        public int UserID { get; set; }

        [Required]
        public string SCRIPT_NAME { get; set; }

        [StringLength(100)]
        public string Template { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        [StringLength(20)]
        public string REQUEST_METHOD { get; set; }

        public string QUERY_STRING { get; set; }

        public string FORM { get; set; }

        public DateTime create_dt { get; set; }
    }
}

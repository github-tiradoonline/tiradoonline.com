using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSnippets
    {
        
        public int SnippetID { get; set; }

        public int SnippetGroupID { get; set; }

        [Required]
        [StringLength(100)]
        public string SnippetName { get; set; }

        public string Snippet { get; set; }

        
        public DateTime create_dt { get; set; }

        
        public DateTime update_dt { get; set; }

        //public virtual SnippetGroups SnippetGroups { get; set; }
    }
}

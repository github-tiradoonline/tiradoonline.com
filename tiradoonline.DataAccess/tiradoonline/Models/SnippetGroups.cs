using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSnippetGroups
    {
        public int SnippetGroupID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string SnippetGroupName { get; set; }

        
        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<Snippets> Snippets { get; set; }
    }
}

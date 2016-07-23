using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSnippetFolderImport
    {
        
        public int SnippetFolderID { get; set; }

        [StringLength(100)]
        public string UserID { get; set; }

        [StringLength(30)]
        public string SnippetFolderName { get; set; }

        public DateTime DateCreated { get; set; }
    }
}

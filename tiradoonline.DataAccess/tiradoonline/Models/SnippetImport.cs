using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelSnippetImport
    {
        
        public int SnippetID { get; set; }
        public int SnippetFolderID { get; set; }

        [StringLength(30)]
        public string SnippetName { get; set; }

        public string SnippetDescription { get; set; }

        public bool SnippetShare { get; set; }

        public DateTime DateCreated { get; set; }
    }
}

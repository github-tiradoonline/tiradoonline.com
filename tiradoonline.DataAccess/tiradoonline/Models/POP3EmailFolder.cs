using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPOP3EmailFolder
    {
        public int POP3EmailFolderID { get; set; }

        public int POP3EmailAccountID { get; set; }

        [Required]
        [StringLength(100)]
        public string POP3EmailFolderName { get; set; }

        public bool CanBeDeleted { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<POP3Email> POP3Email { get; set; }

        //public virtual POP3EmailAccount POP3EmailAccount { get; set; }

        
        //public virtual ICollection<POP3EmailRule> POP3EmailRule { get; set; }
    }
}

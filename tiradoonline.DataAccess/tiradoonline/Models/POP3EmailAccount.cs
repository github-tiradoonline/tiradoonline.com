using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPOP3EmailAccount
    {
        public int POP3EmailAccountID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string POP3EmailAccountName { get; set; }

        [Required]
        [StringLength(100)]
        public string POP3EmailAccountServer { get; set; }

        [Required]
        [StringLength(100)]
        public string POP3EmailAccountEmail { get; set; }

        [Required]
        [StringLength(100)]
        public string POP3EmailAccountUserName { get; set; }

        [Required]
        [StringLength(100)]
        public string POP3EmailAccountPassword { get; set; }

        public bool POP3EmailAccountSSL { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
        //public virtual ICollection<POP3EmailFolder> POP3EmailFolder { get; set; }

        
        //public virtual ICollection<POP3EmailRule> POP3EmailRule { get; set; }
    }
}

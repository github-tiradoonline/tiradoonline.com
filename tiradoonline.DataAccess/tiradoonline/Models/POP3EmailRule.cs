namespace tiradoonline.DataAccess.tiradoonline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class modelPOP3EmailRule
    {
        public int POP3EmailRuleID { get; set; }

        public int POP3EmailAccountID { get; set; }

        public int POP3EmailFolderID { get; set; }

        [Required]
        [StringLength(50)]
        public string POP3EmailEmailAddress { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual POP3EmailAccount POP3EmailAccount { get; set; }

        //public virtual POP3EmailFolder POP3EmailFolder { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPOP3Email
    {
        public int POP3EmailID { get; set; }

        public int POP3EmailFolderID { get; set; }

        [StringLength(100)]
        public string POP3EmailMessageID { get; set; }

        [StringLength(50)]
        public string POP3EmailMessageDateTime { get; set; }

        [StringLength(500)]
        public string POP3EmailFromName { get; set; }

        [StringLength(500)]
        public string POP3EmailFromEmail { get; set; }

        [StringLength(500)]
        public string POP3EmailSubject { get; set; }

        public string POP3EmailBodyText { get; set; }

        public bool Active { get; set; }

        public string POP3EmailMessageId { get; set; }
        public DateTime POP3EmailMessageDateSent { get; set; }
        public List<modelPOP3Email> listPOP3Email { get; set; }

        public DateTime? create_dt { get; set; }

        //public virtual POP3EmailFolder POP3EmailFolder { get; set; }
    }
}

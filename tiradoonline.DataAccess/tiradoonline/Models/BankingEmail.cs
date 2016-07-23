using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelBankingEmail
    {
        public int BankingEmailID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string ToEmail { get; set; }

        [Required]
        [StringLength(100)]
        public string FromEmail { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        //[Column(TypeName = "text")]
        [Required]
        public string BodyText { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        //public virtual Users Users1 { get; set; }
    }
}

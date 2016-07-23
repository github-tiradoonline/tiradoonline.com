using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelEmailTemplates
    {
        
        public int EmailTemplateID { get; set; }

        public int UserID { get; set; }

        [StringLength(200)]
        public string CreateAccountSubject { get; set; }

        public string CreateAccountEmail { get; set; }

        [StringLength(200)]
        public string ForgotPasswordSubject { get; set; }

        public string ForgotPasswordEmail { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCompany
    {
        public int JobCompanyID { get; set; }

        public int? JobIDOld { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCompanyName { get; set; }

        [StringLength(50)]
        public string JobCompanyPhone { get; set; }

        [StringLength(50)]
        public string JobCompanyPhone2 { get; set; }

        [StringLength(50)]
        public string JobCompanyFax { get; set; }

        [StringLength(100)]
        public string JobCompanyEmail { get; set; }

        [StringLength(100)]
        public string JobCompanyWebsite { get; set; }

        [StringLength(500)]
        public string JobCompanyLinkedIn { get; set; }

        [StringLength(500)]
        public string JobCompanyTwitter { get; set; }

        [StringLength(500)]
        public string JobCompanyFacebook { get; set; }

        [StringLength(500)]
        public string JobCompanyGooglePlus { get; set; }

        [StringLength(500)]
        public string JobCompanyYouTube { get; set; }

        [StringLength(500)]
        public string JobCompanyInstagram { get; set; }

        [StringLength(500)]
        public string JobCompanyPinterest { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }

        
    }
}

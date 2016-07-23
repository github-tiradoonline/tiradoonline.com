using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCompanyContact
    {
        public int JobCompanyContactID { get; set; }

        public int JobCompanyID { get; set; }

        [StringLength(100)]
        public string JobCompanyContactTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCompanyContactFirstName { get; set; }

        [StringLength(50)]
        public string JobCompanyContactLastName { get; set; }

        [StringLength(50)]
        public string JobCompanyContactWorkPhone { get; set; }

        [StringLength(50)]
        public string JobCompanyContactWorkPhone2 { get; set; }

        [StringLength(50)]
        public string JobCompanyContactFax { get; set; }

        [StringLength(50)]
        public string JobCompanyContactCellPhone { get; set; }

        [StringLength(100)]
        public string JobCompanyContactEmail { get; set; }

        [StringLength(100)]
        public string JobCompanyContactEmail2 { get; set; }

        [StringLength(500)]
        public string JobCompanyContactLinkedIn { get; set; }

        [StringLength(500)]
        public string JobCompanyContactTwitter { get; set; }

        [StringLength(500)]
        public string JobCompanyContactFacebook { get; set; }

        [StringLength(500)]
        public string JobCompanyContactGooglePlus { get; set; }

        [StringLength(500)]
        public string JobCompanyContactInstagram { get; set; }

        [StringLength(500)]
        public string JobCompanyContactSkype { get; set; }

        [StringLength(500)]
        public string JobCompanyContactHotmail { get; set; }

        [StringLength(500)]
        public string JobCompanyContactYahoo { get; set; }

        [StringLength(500)]
        public string JobCompanyContactAIM { get; set; }

        [StringLength(500)]
        public string JobCompanyContactGmail { get; set; }

        public string JobCompanyContactNotes { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }

        
        //public virtual ICollection<Jobs> Jobs { get; set; }
    }
}

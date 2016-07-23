using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelJobCompanyAddress
    {
        public int JobCompanyAddressID { get; set; }

        public int JobCompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCompanyAddress1 { get; set; }

        [StringLength(50)]
        public string JobCompanyAddress2 { get; set; }

        [StringLength(50)]
        public string JobCompanyAddressCity { get; set; }

        public int StateID { get; set; }

        [StringLength(20)]
        public string JobCompanyAddressZipCode { get; set; }

        [StringLength(50)]
        public string JobCompanyAddressPhone { get; set; }

        [StringLength(50)]
        public string JobCompanyAddressPhone2 { get; set; }

        [StringLength(50)]
        public string JobCompanyAddressFax { get; set; }

        [StringLength(100)]
        public string JobCompanyAddressEmail { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual JobCompany JobCompany { get; set; }
    }
}

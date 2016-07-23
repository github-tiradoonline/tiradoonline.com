using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelCollectionAgency
    {

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string CollectionAgencyName { get; set; }

        [Required]
        [StringLength(100)]
        public string CollectionAgencyAddress1 { get; set; }

        [StringLength(100)]
        public string CollectionAgencyAddress2 { get; set; }

        [Required]
        [StringLength(100)]
        public string CollectionAgencyCity { get; set; }

        public int StateID { get; set; }

        [Required]
        [StringLength(20)]
        public string CollectionAgencyZipCode { get; set; }

        [StringLength(20)]
        public string CollectionAgencyPhone { get; set; }

        [StringLength(20)]
        public string CollectionAgencyFax { get; set; }

        [StringLength(100)]
        public string CollectionAgencyWebsite { get; set; }

        [StringLength(100)]
        public string CollectionAgencyEmail { get; set; }

        [StringLength(2000)]
        public string CollectionAgencyNotes { get; set; }

        public DateTime create_dt { get; set; }

        
        //public virtual ICollection<Collection> Collection { get; set; }

        //public virtual Users Users { get; set; }
    }
}

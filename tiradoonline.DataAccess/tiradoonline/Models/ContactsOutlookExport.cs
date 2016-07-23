using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelContactsOutlookExport
    {
        public int ContactsOutlookExportID { get; set; }

        [Required]
        [StringLength(50)]
        public string EntryID { get; set; }

        public int UserID { get; set; }

        [StringLength(100)]
        public string FileAs { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string JobTitle { get; set; }

        [StringLength(100)]
        public string Email1Address { get; set; }

        [StringLength(100)]
        public string Email2Address { get; set; }

        [StringLength(100)]
        public string Email3Address { get; set; }

        [StringLength(100)]
        public string WebPage { get; set; }

        [StringLength(20)]
        public string IMAddress { get; set; }

        [StringLength(50)]
        public string MobileTelephoneNumber { get; set; }

        [StringLength(50)]
        public string HomeTelephoneNumber { get; set; }

        [StringLength(50)]
        public string BusinessTelephoneNumber { get; set; }

        [StringLength(50)]
        public string BusinessFaxNumber { get; set; }

        [StringLength(50)]
        public string HomeAddressStreet { get; set; }

        [StringLength(50)]
        public string HomeAddressCity { get; set; }

        [StringLength(50)]
        public string HomeAddressState { get; set; }

        [StringLength(50)]
        public string HomeAddressPostalCode { get; set; }

        [StringLength(50)]
        public string BusinessAddressStreet { get; set; }

        [StringLength(50)]
        public string BusinessAddressCity { get; set; }

        [StringLength(50)]
        public string BusinessAddressState { get; set; }

        [StringLength(50)]
        public string BusinessAddressPostalCode { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public bool HasPicture { get; set; }

        public DateTime create_dt { get; set; }
    }
}

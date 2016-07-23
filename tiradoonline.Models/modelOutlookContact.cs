using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiradoonline.Models
{
    public class modelOutlookContact
    {
        public string EntryID { get; set; }
        public string FileAs { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string WebPage { get; set; }
        public string IMAddress { get; set; }
        public string MobileTelephoneNumber { get; set; }
        public string HomeTelephoneNumber { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string BusinessFaxNumber { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressStateName { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressStateName { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}

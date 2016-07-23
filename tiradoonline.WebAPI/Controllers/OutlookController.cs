using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tiradoonline.ClassLibrary;
using tiradoonline.Models;

namespace tiradoonline.Intranet.Controllers
{
    public class OutlookController : Controller
    {
        // GET: Outlook
        [HttpPost]
        public JsonResult CreateOutlookContact(
                string FileAs, 
                string FirstName, 
                string LastName, 
                string FullName, 
                string JobTitle, 
                string CompanyName, 
                string Email1Address, 
                string Email2Address, 
                string Email3Address, 
                string WebPage, 
                string IMAddress, 
                string MobileTelephoneNumber, 
                string HomeTelephoneNumber, 
                string BusinessTelephoneNumber, 
                string BusinessFaxNumber, 
                string HomeAddressStreet, 
                string HomeAddressCity, 
                string HomeAddressStateName, 
                string HomeAddressPostalCode, 
                string BusinessAddressStreet, 
                string BusinessAddressCity, 
                string BusinessAddressStateName, 
                string BusinessAddressPostalCode
        )
        {
            modelOutlookContact objModelOutlookContact = new modelOutlookContact();
            try
            {
                objModelOutlookContact.EntryID = "";
                objModelOutlookContact.FileAs = FileAs;
                objModelOutlookContact.FirstName = FirstName;
                objModelOutlookContact.LastName = LastName;
                objModelOutlookContact.FullName = FirstName + " " + LastName;
                objModelOutlookContact.JobTitle = JobTitle;
                objModelOutlookContact.CompanyName = CompanyName;
                objModelOutlookContact.Email1Address = Email1Address;
                objModelOutlookContact.Email2Address = Email2Address;
                objModelOutlookContact.Email3Address = Email3Address;
                objModelOutlookContact.WebPage = WebPage;
                objModelOutlookContact.IMAddress = IMAddress;
                objModelOutlookContact.MobileTelephoneNumber = MobileTelephoneNumber;
                objModelOutlookContact.HomeTelephoneNumber = HomeTelephoneNumber;
                objModelOutlookContact.BusinessTelephoneNumber = BusinessTelephoneNumber;
                objModelOutlookContact.BusinessFaxNumber = BusinessFaxNumber;
                objModelOutlookContact.HomeAddressStreet = HomeAddressStreet;
                objModelOutlookContact.HomeAddressCity = HomeAddressCity;
                objModelOutlookContact.HomeAddressStateName = HomeAddressStateName;
                objModelOutlookContact.HomeAddressPostalCode = HomeAddressPostalCode;
                objModelOutlookContact.BusinessAddressStreet = BusinessAddressStreet;
                objModelOutlookContact.BusinessAddressCity = BusinessAddressCity;
                objModelOutlookContact.BusinessAddressStateName = BusinessAddressStateName;
                objModelOutlookContact.BusinessAddressPostalCode = BusinessAddressPostalCode;
                objModelOutlookContact.ErrorMessage = String.Format("Contact: {0} created", FullName);

                clsOutlook objOutlook = new clsOutlook();
                bool result = objOutlook.CreateOutlookContact(ref objModelOutlookContact);
                objOutlook = null;

            }
            catch (Exception ex)
            {
                clsLogs.LogToEmail = true;
                clsLogs.LogToTextFile = true;
                clsLogs.Log(Request.ServerVariables["SERVER_NAME"].ToString() + ":OutlookController:CreateOutlookContact", @"c:\", ex.ToString());
                objModelOutlookContact.ErrorMessage = String.Format("Eror creating Contact: {0} ----- {1}", FullName, ex.ToString());
            }
            return Json(objModelOutlookContact, JsonRequestBehavior.AllowGet);
        }
    }
}
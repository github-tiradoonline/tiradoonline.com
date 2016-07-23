using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using NetOffice;
using Outlook = NetOffice.OutlookApi;
using NetOffice.OutlookApi.Enums;

using tiradoonline.Models;


namespace tiradoonline.ClassLibrary
{
    public class clsOutlook
    {
        public int totalContacts;

        /***************************************************/
        /* CONSTRUCTOR                                      */
        /* - INITIALIZE TOTAL NUMBER OF OUTLOOK CONTACTS */
        /***************************************************/
        public clsOutlook()
        {
            string err = string.Empty;
            //Outlook.Application outlookApp = new Outlook.Application();
            //Outlook.MAPIFolder contacts = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
            
            //this.totalContacts = contacts.Items.Count;

            //outlookApp = null;
            //contacts = null;
        }

        ///****************************************/
        ///* DELETE OUTLOOK CONTACT                */
        ///* - pass it OUTLOOK ENTRYID             */
        ///****************************************/
        //public bool DeleteOutlookContact(string EntryID, ref string ErrorMessage)
        //{
        //    bool boolContactDeleted = true;

        //    Outlook.Application outlookApp = new Outlook.Application();

        //    Outlook.MAPIFolder contactFolder = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts); ;
        //    outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);


        //    COMObject searchFolder = contactFolder.Items;

        //    if (contactFolder.Items.Count > 0)
        //    {
        //        foreach (Outlook.ContactItem contact in searchFolder)
        //        {
        //            if (contact.EntryID.Contains(EntryID))
        //            {
        //                try
        //                {
        //                    contact.Delete();
        //                    boolContactDeleted = true;
        //                }
        //                catch (Exception ex)
        //                {
        //                    ErrorMessage += "ERROR: " + ex.Message + Environment.NewLine;
        //                    boolContactDeleted = false;
        //                }
        //            }
        //        }
        //    }

        //    contactFolder  = null;
        //    outlookApp = null;
        //    return boolContactDeleted;
        //}

        /****************************************/
        /* CREATE OUTLOOK CONTACT               */
        /****************************************/
        public bool CreateOutlookContact
                (
                    ref modelOutlookContact objModelOutlookContact
                )
        {
            bool boolContactAdded = true;

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MAPIFolder contacts = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);

            Outlook.ContactItem contact = (Outlook.ContactItem)outlookApp.CreateItem(OlItemType.olContactItem);

            try
            {

                contact.FileAs = objModelOutlookContact.FileAs;
                contact.FirstName = objModelOutlookContact.FirstName;
                contact.LastName = objModelOutlookContact.LastName;
                contact.FullName = objModelOutlookContact.FullName;
                contact.CompanyName = objModelOutlookContact.CompanyName;
                contact.JobTitle = objModelOutlookContact.JobTitle;
                contact.Email1Address = objModelOutlookContact.Email1Address;
                contact.Email2Address = objModelOutlookContact.Email2Address;
                contact.Email3Address = objModelOutlookContact.Email3Address;
                contact.WebPage = objModelOutlookContact.WebPage;
                contact.IMAddress = objModelOutlookContact.IMAddress;
                contact.MobileTelephoneNumber = objModelOutlookContact.MobileTelephoneNumber;
                contact.HomeTelephoneNumber = objModelOutlookContact.HomeTelephoneNumber;
                contact.BusinessTelephoneNumber = objModelOutlookContact.BusinessTelephoneNumber;
                contact.BusinessFaxNumber = objModelOutlookContact.BusinessFaxNumber;
                contact.HomeAddressStreet = objModelOutlookContact.HomeAddressStreet;
                contact.HomeAddressCity = objModelOutlookContact.HomeAddressCity;
                contact.HomeAddressState = objModelOutlookContact.HomeAddressStateName;
                contact.HomeAddressPostalCode = objModelOutlookContact.HomeAddressPostalCode;
                contact.BusinessAddressStreet = objModelOutlookContact.BusinessAddressStreet;
                contact.BusinessAddressCity = objModelOutlookContact.BusinessAddressCity;
                contact.BusinessAddressState = objModelOutlookContact.BusinessAddressStateName;
                contact.BusinessAddressPostalCode = objModelOutlookContact.BusinessAddressPostalCode;

                contact.Save();


                boolContactAdded = true;
            }
            catch (Exception ex)
            {
                objModelOutlookContact.ErrorMessage = "ERROR: " + ex.Message + Environment.NewLine;
                boolContactAdded = false;
            }

            contact = null;
            outlookApp = null;
            return boolContactAdded;
        }

    /****************************************/
    /* CREATE OUTLOOK CONTACT                */
    /****************************************/
        public bool SaveOutlookContact
                (
                    string EntryID,
                    ref modelOutlookContact objModelOutlookContact
                )
        {
            bool boolContactUpdated = true;

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MAPIFolder contactFolder  = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
            outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);

            try
            {
                foreach (COMObject item in contactFolder.Items)
                {
                    Outlook.ContactItem contact = item as Outlook.ContactItem;

                    if (contact.EntryID.Contains(EntryID))
                    {
                        contact.FileAs = objModelOutlookContact.FileAs;
                        contact.FirstName = objModelOutlookContact.FirstName;
                        contact.LastName = objModelOutlookContact.LastName;
                        contact.FullName = objModelOutlookContact.FullName;
                        contact.CompanyName = objModelOutlookContact.CompanyName;
                        contact.JobTitle = objModelOutlookContact.JobTitle;
                        contact.Email1Address = objModelOutlookContact.Email1Address;
                        contact.Email2Address = objModelOutlookContact.Email2Address;
                        contact.Email3Address = objModelOutlookContact.Email3Address;
                        contact.WebPage = objModelOutlookContact.WebPage;
                        contact.IMAddress = objModelOutlookContact.IMAddress;
                        contact.MobileTelephoneNumber = objModelOutlookContact.MobileTelephoneNumber;
                        contact.HomeTelephoneNumber = objModelOutlookContact.HomeTelephoneNumber;
                        contact.BusinessTelephoneNumber = objModelOutlookContact.BusinessTelephoneNumber;
                        contact.BusinessFaxNumber = objModelOutlookContact.BusinessFaxNumber;
                        contact.HomeAddressStreet = objModelOutlookContact.HomeAddressStreet;
                        contact.HomeAddressCity = objModelOutlookContact.HomeAddressCity;
                        contact.HomeAddressState = objModelOutlookContact.HomeAddressStateName;
                        contact.HomeAddressPostalCode = objModelOutlookContact.HomeAddressPostalCode;
                        contact.BusinessAddressStreet = objModelOutlookContact.BusinessAddressStreet;
                        contact.BusinessAddressCity = objModelOutlookContact.BusinessAddressCity;
                        contact.BusinessAddressState = objModelOutlookContact.BusinessAddressStateName;
                        contact.BusinessAddressPostalCode = objModelOutlookContact.BusinessAddressPostalCode;
                        contact.Save();
                    }
                }

                boolContactUpdated = true;
            }
            catch (Exception ex)
            {
                objModelOutlookContact.ErrorMessage = "ERROR: " + ex.Message + Environment.NewLine;
                boolContactUpdated = false;
            }

            outlookApp = null;
            return boolContactUpdated;
        }

    
        /****************************************/
        /* GET OUTLOOK CONTACT                */
        /****************************************/
        public bool GetOutlookContact
                (
                    int itemNumber,
                    string ContactPhotoPath,
                    ref string EntryID,
                    ref string FileAs,
                    ref string FirstName,
                    ref string LastName,
                    ref string FullName,
                    ref string JobTitle,
                    ref string CompanyName,
                    ref string Email1Address,
                    ref string Email2Address,
                    ref string Email3Address,
                    ref string WebPage,
                    ref string IMAddress,
                    ref string MobileTelephoneNumber,
                    ref string HomeTelephoneNumber,
                    ref string BusinessTelephoneNumber,
                    ref string BusinessFaxNumber,
                    ref string HomeAddressStreet,
                    ref string HomeAddressCity,
                    ref string HomeAddressState,
                    ref string HomeAddressPostalCode,
                    ref string BusinessAddressStreet,
                    ref string BusinessAddressCity,
                    ref string BusinessAddressState,
                    ref string BusinessAddressPostalCode,
                    ref bool HasPicture,
                    ref DateTime LastModificationTime,
                    ref string ErrorMessage
                )
        {
            bool boolGetOutlookContact = true;

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MAPIFolder contacts = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
            outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);

            try
            {
                Outlook.ContactItem contact = (Outlook.ContactItem)contacts.Items[itemNumber];

                if (!string.IsNullOrEmpty(contact.EntryID)) EntryID = contact.EntryID;
                if (!string.IsNullOrEmpty(contact.FileAs)) FileAs = contact.FileAs;
                if (!string.IsNullOrEmpty(contact.FirstName)) FirstName = contact.FirstName;
                if (!string.IsNullOrEmpty(contact.LastName)) LastName = contact.LastName;
                if (!string.IsNullOrEmpty(contact.FullName)) FullName = contact.FirstName + " " + contact.LastName;
                if (!string.IsNullOrEmpty(contact.CompanyName)) CompanyName = contact.CompanyName;
                if (!string.IsNullOrEmpty(contact.JobTitle)) JobTitle = contact.JobTitle;
                if (!string.IsNullOrEmpty(contact.Email1Address)) Email1Address = contact.Email1Address;
                if (!string.IsNullOrEmpty(contact.Email2Address)) Email2Address = contact.Email2Address;
                if (!string.IsNullOrEmpty(contact.Email3Address)) Email3Address = contact.Email3Address;
                if (!string.IsNullOrEmpty(contact.WebPage)) WebPage = contact.WebPage;
                if (!string.IsNullOrEmpty(contact.IMAddress)) IMAddress = contact.IMAddress;
                if (!string.IsNullOrEmpty(contact.MobileTelephoneNumber)) MobileTelephoneNumber = contact.MobileTelephoneNumber;
                if (!string.IsNullOrEmpty(contact.HomeTelephoneNumber)) HomeTelephoneNumber = contact.HomeTelephoneNumber;
                if (!string.IsNullOrEmpty(contact.BusinessTelephoneNumber)) BusinessTelephoneNumber = contact.BusinessTelephoneNumber;
                if (!string.IsNullOrEmpty(contact.BusinessFaxNumber)) BusinessFaxNumber = contact.BusinessFaxNumber;
                if (!string.IsNullOrEmpty(contact.HomeAddressStreet)) HomeAddressStreet = contact.HomeAddressStreet;
                if (!string.IsNullOrEmpty(contact.HomeAddressCity)) HomeAddressCity = contact.HomeAddressCity;
                if (!string.IsNullOrEmpty(contact.HomeAddressState)) HomeAddressState = contact.HomeAddressState;
                if (!string.IsNullOrEmpty(contact.HomeAddressPostalCode)) HomeAddressPostalCode = contact.HomeAddressPostalCode;
                if (!string.IsNullOrEmpty(contact.BusinessAddressStreet)) BusinessAddressStreet = contact.BusinessAddressStreet;
                if (!string.IsNullOrEmpty(contact.BusinessAddressCity)) BusinessAddressCity = contact.BusinessAddressCity;
                if (!string.IsNullOrEmpty(contact.BusinessAddressState)) BusinessAddressState = contact.BusinessAddressState;
                if (!string.IsNullOrEmpty(contact.BusinessAddressPostalCode)) BusinessAddressPostalCode = contact.BusinessAddressPostalCode;
                if (!string.IsNullOrEmpty(contact.LastModificationTime.ToString())) LastModificationTime = contact.LastModificationTime;
                HasPicture = contact.HasPicture;

                if (HasPicture)
                {
                    foreach (Outlook.Attachment att in contact.Attachments)
                    {
                        string picturePath = "";

                        if (att.DisplayName == "ContactPicture.jpg")
                        {
                            try
                            {
                                picturePath = System.IO.Path.GetDirectoryName(ContactPhotoPath) + "\\" + EntryID + ".jpg";
                                if (!System.IO.File.Exists(picturePath))
                                    att.SaveAsFile(picturePath);
                            }
                            catch
                            {
                                picturePath = "";
                            }
                        }
                    }                        //contact.Attachments["ContactPicture.jpg"].SaveAsFile(@"{some_path}\ContactPicture.jpg")
                }
                
                contact = null;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            outlookApp = null;
            contacts = null;

            return boolGetOutlookContact;
        }


        /****************************************/
        /* GET OUTLOOK CONTACT                */
        /****************************************/
        public string DeleteDuplicateOutlookContacts()
        {
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MAPIFolder contactFolder = outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
            outlookApp.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);

            clsDebugger objDebugger = new clsDebugger();

            string results = string.Empty;

            int x = 1;
            string entryid = string.Empty;
            string fileas = string.Empty;
            string ErrorMessage = string.Empty;

            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("EntryID", typeof(string));
                table.Columns.Add("FileAs", typeof(string)); 
                
                foreach (Outlook.ContactItem contact in contactFolder.Items)
                {
                    entryid = contact.EntryID;
                    fileas = contact.FileAs;
                    table.Rows.Add(entryid, fileas);
                    //results += objDebugger.LogTextOut("ClassLibraryOutlook", x.ToString() + ") " + entryid + " - " + fileas + Environment.NewLine);
                    x++;
                }

                DataView view = table.DefaultView;
                view.Sort = "FileAs ASC";
                DataTable t = view.ToTable();;

                string tempFileAs = string.Empty;
                int totalDuplicates = 0;
                for (int y = 0; y < t.Rows.Count; y++)
                {
                    //results += objDebugger.LogTextOut("ClassLibraryOutlook", y.ToString() + ") " + t.Rows[y][1].ToString() + " (" + t.Rows[y][0].ToString() + "). ");

                    if ((string)tempFileAs != (string)t.Rows[y][1].ToString())
                    {
                        tempFileAs = t.Rows[y][1].ToString();
                    }
                    else
                    {
                        results += objDebugger.LogTextOut("ClassLibraryOutlook", y.ToString() + ") Duplicate " + t.Rows[y][1].ToString() + " (" + t.Rows[y][0].ToString() + ") found. ");
                        totalDuplicates++;
                        try
                        {
                            results += objDebugger.LogTextOut("ClassLibraryOutlook", y.ToString() + ") Deleting Duplicate (" + t.Rows[y][0].ToString() + ")");
                            //bool deleteOutlookContact = DeleteOutlookContact((string)t.Rows[y][0].ToString(), ref ErrorMessage);
                        }
                        catch (Exception ex)
                        {
                            results += objDebugger.LogTextOut("ClassLibraryOutlook", y.ToString() + ") Deleting Duplicate (" + t.Rows[y][0].ToString() + ") FAILED" + Environment.NewLine + ex.Message);
                        }
                    }

                }
                string s = string.Empty;

                
                table = null;

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                results += objDebugger.LogTextOut("ClassLibraryOutlook", x.ToString() + ") " + entryid + " - " + fileas + " " + ErrorMessage + Environment.NewLine);

            }
            objDebugger = null;


            outlookApp = null;
            contactFolder = null;

            return results;
        }
    }
}

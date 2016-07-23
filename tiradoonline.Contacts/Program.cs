using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using tiradoonline.ClassLibrary;
using System.Configuration;

namespace tiradoonline.Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string logString = string.Empty;
        public int totalErrors = 0;
        public clsDebugger objDebugger = new clsDebugger();

        /********************************************************************************************************************
         * 
         * THIS WILL DELETE ANY OUTLOOK CONTACTS THAT HAVE BEEN DELETED ALREADY IN CONTACTS TABLE.
         *              
         ***********************************************************************************************************************/
        public string DeleteOutlookContacts(int UserID)
        {
            logString = string.Empty;
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            logString += objDebugger.LogTextOut("ContactsSync", "DeleteOutlookContacts");
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            totalErrors = 0;

            string connection_String = ConfigurationManager.AppSettings["SQLConnectionString"];

            SqlConnection objSQLConnection = new SqlConnection(connection_String);
            objSQLConnection.Open();
            SqlCommand objCommand = new SqlCommand("sp_Contacts_Active_0_get", objSQLConnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@UserID", UserID);

            SqlDataReader objDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);

            int contactsDeleted = 0;

            if (objDataReader.HasRows)
            {

                while (objDataReader.Read())
                {
                    string ErrorMessage = string.Empty;
                    if (DeleteOutlookContact((string)objDataReader["EntryID"], ref ErrorMessage))
                    {
                        contactsDeleted++;
                        logString += objDebugger.LogTextOut("ContactsSync", "Outlook Contact '" + (string)objDataReader["FileAs"] + "' deleted");
                    }
                    else
                    {
                        totalErrors++;
                        logString += objDebugger.LogTextOut("ContactsSync", ErrorMessage);
                    }

                }

                

            }

            objCommand.Dispose();
            objCommand = null;

            objSQLConnection.Close();
            objSQLConnection.Dispose();
            objSQLConnection = null;

            logString += objDebugger.LogTextOut("ContactsSync", Environment.NewLine + "errors: " + totalErrors.ToString());
            logString += objDebugger.LogTextOut("ContactsSync", contactsDeleted.ToString() + " OUTLOOK CONTACTS DELETED.");

            return logString;
        }

        /*********************************************************************************************************************/
        /* THIS WILL INSERT NEW OUTLOOK CONTACTS FROM Contacts TABLE WHERE ENTRYID = '0'                                     */
        /*********************************************************************************************************************/
        public string AddNewOutlookContacts(int UserID)
        {
            logString = string.Empty;
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            logString += objDebugger.LogTextOut("ContactsSync", "AddNewOutlookContacts");
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            totalErrors = 0;

            string connection_String = ConfigurationManager.AppSettings["SQLConnectionString"];
            SqlConnection objSQLConnection = new SqlConnection(connection_String);
            objSQLConnection.Open();
            SqlCommand objCommand = new SqlCommand("sp_Contacts_0_get", objSQLConnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@UserID", UserID);
            SqlDataReader objDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);

            int contactsAdded = 0;

            

            while (objDataReader.Read())
            {
                string ErrorMessage = string.Empty;

                try
                {
                    if (CreateOutlookContact
                        (
                            (string)objDataReader["EntryID"],
                            (string)objDataReader["FileAs"],
                            (string)objDataReader["FirstName"],
                            (string)objDataReader["LastName"],
                            (string)objDataReader["FullName"],
                            (string)objDataReader["JobTitle"],
                            (string)objDataReader["CompanyName"],
                            (string)objDataReader["Email1Address"],
                            (string)objDataReader["Email2Address"],
                            (string)objDataReader["Email3Address"],
                            (string)objDataReader["WebPage"],
                            (string)objDataReader["IMAddress"],
                            (string)objDataReader["MobileTelephoneNumber"],
                            (string)objDataReader["HomeTelephoneNumber"],
                            (string)objDataReader["BusinessTelephoneNumber"],
                            (string)objDataReader["BusinessFaxNumber"],
                            (string)objDataReader["HomeAddressStreet"],
                            (string)objDataReader["HomeAddressCity"],
                            (string)objDataReader["HomeAddressState"],
                            (string)objDataReader["HomeAddressPostalCode"],
                            (string)objDataReader["BusinessAddressStreet"],
                            (string)objDataReader["BusinessAddressCity"],
                            (string)objDataReader["BusinessAddressState"],
                            (string)objDataReader["BusinessAddressPostalCode"],
                            ref ErrorMessage
                        )
                        )
                    {
                        contactsAdded++;
                        logString += objDebugger.LogTextOut("ContactsSync", "Outlook Contact '" + (string)objDataReader["FileAs"] + "' CREATED");
                    }
                    else
                    {
                        totalErrors++;
                        logString += objDebugger.LogTextOut("ContactsSync", ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    logString += objDebugger.LogTextOut("ContactsSync", (string)objDataReader["FileAs"] + " - ERROR: " + ex.Message);
                    totalErrors++;
                }

            }

            


            objCommand.Dispose();
            objCommand = null;

            objSQLConnection.Close();
            objSQLConnection.Dispose();
            objSQLConnection = null;

            /*
             DELETE FROM Contacts WHERE ENTRY IS 0, WE DELETE IT BECAUSE IT'S GONNA BE RECREATED AS A NEW OUTLOOK CONTACT THEN ContactSys WILL ADD IT WITH AN ENTRYID
            */

            if (contactsAdded > 0)
            {
                SqlConnection objSQLConnection2 = new SqlConnection(connection_String);
                objSQLConnection2.Open();
                SqlCommand objCommand2 = new SqlCommand("sp_Contacts_EntryID_0_delete", objSQLConnection2);
                objCommand2.Parameters.AddWithValue("@UserID", UserID);
                objCommand2.CommandType = CommandType.StoredProcedure;
                objCommand2.ExecuteNonQuery();

                objCommand2.Dispose();
                objCommand2 = null;

                objSQLConnection2.Close();
                objSQLConnection2 = null;
            }
            objDataReader.Close();
            objDataReader = null;
            objCommand = null;

            logString += objDebugger.LogTextOut("ContactsSync", "errors: " + totalErrors.ToString());
            logString += objDebugger.LogTextOut("ContactsSync", contactsAdded.ToString() + " ContactsOutlookExport added.");
            return logString;
        }

        /*********************************************************************************************************************/
        /* THIS WILL TRUNCATE THE ContactsOutlookExport TABLE AND INSERT ALL OUTLOOK CONTACTS INTO THE ContactsOutlookExport */
        /*********************************************************************************************************************/
        public string ImportOutlookContacts(int UserID, string path)
        {
            
            logString = string.Empty;
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            logString += objDebugger.LogTextOut("ContactsSync", "ImportOutlookContacts");
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            totalErrors = 0;

            List<string> entryIDList = new List<string>();

            totalErrors = 0;
            string EntryID = string.Empty;
            string FileAs = string.Empty;
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string FullName = string.Empty;
            string CompanyName = string.Empty;
            string JobTitle = string.Empty;
            string Email1Address = string.Empty;
            string Email2Address = string.Empty;
            string Email3Address = string.Empty;
            string WebPage = string.Empty;
            string IMAddress = string.Empty;
            string MobileTelephoneNumber = string.Empty;
            string HomeTelephoneNumber = string.Empty;
            string BusinessTelephoneNumber = string.Empty;
            string BusinessFaxNumber = string.Empty;
            string HomeAddressStreet = string.Empty;
            string HomeAddressCity = string.Empty;
            string HomeAddressState = string.Empty;
            string HomeAddressPostalCode = string.Empty;
            string BusinessAddressStreet = string.Empty;
            string BusinessAddressCity = string.Empty;
            string BusinessAddressState = string.Empty;
            string BusinessAddressPostalCode = string.Empty;
            bool HasPicture = false;
            DateTime LastModificationTime;

            int totalContacts = 0;
            //int totalContacts = totalContacts;
            


            //SqlConnection objSQLConnection = new SqlConnection(@"Server=.\SQL2K8;Database=balanceintranet;Integrated Security=false;User Id=balanceintranet_user;Password=balanceintranet;");
            string connection_String = ConfigurationManager.AppSettings["SQLConnectionString"];
            SqlConnection objSQLConnection = new SqlConnection(connection_String);
            objSQLConnection.Open();

            int totalrows = 0;

            SqlCommand objCommand = new SqlCommand("sp_ContactsOutlookExport_delete", objSQLConnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.ExecuteNonQuery();
            objCommand = null;

            for (int i = 1; i < totalContacts; i++)
            {
                EntryID = string.Empty;
                FileAs = string.Empty;
                FirstName = string.Empty;
                LastName = string.Empty;
                FullName = string.Empty;
                CompanyName = string.Empty;
                JobTitle = string.Empty;
                Email1Address = string.Empty;
                Email2Address = string.Empty;
                Email3Address = string.Empty;
                WebPage = string.Empty;
                IMAddress = string.Empty;
                MobileTelephoneNumber = string.Empty;
                HomeTelephoneNumber = string.Empty;
                BusinessTelephoneNumber = string.Empty;
                BusinessFaxNumber = string.Empty;
                HomeAddressStreet = string.Empty;
                HomeAddressCity = string.Empty;
                HomeAddressState = string.Empty;
                HomeAddressPostalCode = string.Empty;
                BusinessAddressStreet = string.Empty;
                BusinessAddressCity = string.Empty;
                BusinessAddressState = string.Empty;
                BusinessAddressPostalCode = string.Empty;
                HasPicture = false;
                LastModificationTime = DateTime.Now;
                string ErrorMessage = string.Empty;

                try
                {
                    if (GetOutlookContact
                        (
                            i,
                            path,
                            ref EntryID,
                            ref FileAs,
                            ref FirstName,
                            ref LastName,
                            ref FullName,
                            ref JobTitle,
                            ref CompanyName,
                            ref Email1Address,
                            ref Email2Address,
                            ref Email3Address,
                            ref WebPage,
                            ref IMAddress,
                            ref MobileTelephoneNumber,
                            ref HomeTelephoneNumber,
                            ref BusinessTelephoneNumber,
                            ref BusinessFaxNumber,
                            ref HomeAddressStreet,
                            ref HomeAddressCity,
                            ref HomeAddressState,
                            ref HomeAddressPostalCode,
                            ref BusinessAddressStreet,
                            ref BusinessAddressCity,
                            ref BusinessAddressState,
                            ref BusinessAddressPostalCode,
                            ref HasPicture,
                            ref LastModificationTime,
                            ref ErrorMessage
                        )
                    )
                    {
                        if (EntryID != string.Empty)
                        {
                            entryIDList.Add(EntryID);
                        }

                        objCommand = new SqlCommand("sp_ContactsOutlookExport_insert", objSQLConnection);
                        objCommand.CommandType = CommandType.StoredProcedure;
                        objCommand.Parameters.AddWithValue("@EntryID", EntryID);
                        objCommand.Parameters.AddWithValue("@UserID", UserID);
                        objCommand.Parameters.AddWithValue("@FileAs", FileAs);
                        objCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        objCommand.Parameters.AddWithValue("@LastName", LastName);
                        objCommand.Parameters.AddWithValue("@FullName", FullName);
                        objCommand.Parameters.AddWithValue("@CompanyName", CompanyName);
                        objCommand.Parameters.AddWithValue("@JobTitle", JobTitle);
                        objCommand.Parameters.AddWithValue("@Email1Address", Email1Address);
                        objCommand.Parameters.AddWithValue("@Email2Address", Email2Address);
                        objCommand.Parameters.AddWithValue("@Email3Address", Email3Address);
                        objCommand.Parameters.AddWithValue("@WebPage", WebPage);
                        objCommand.Parameters.AddWithValue("@IMAddress", IMAddress);
                        objCommand.Parameters.AddWithValue("@MobileTelephoneNumber", MobileTelephoneNumber);
                        objCommand.Parameters.AddWithValue("@HomeTelephoneNumber", HomeTelephoneNumber);
                        objCommand.Parameters.AddWithValue("@BusinessTelephoneNumber", BusinessTelephoneNumber);
                        objCommand.Parameters.AddWithValue("@BusinessFaxNumber", BusinessFaxNumber);
                        objCommand.Parameters.AddWithValue("@HomeAddressStreet", HomeAddressStreet);
                        objCommand.Parameters.AddWithValue("@HomeAddressCity", HomeAddressCity);
                        objCommand.Parameters.AddWithValue("@HomeAddressState", HomeAddressState);
                        objCommand.Parameters.AddWithValue("@HomeAddressPostalCode", HomeAddressPostalCode);
                        objCommand.Parameters.AddWithValue("@BusinessAddressStreet", BusinessAddressStreet);
                        objCommand.Parameters.AddWithValue("@BusinessAddressCity", BusinessAddressCity);
                        objCommand.Parameters.AddWithValue("@BusinessAddressState", BusinessAddressState);
                        objCommand.Parameters.AddWithValue("@BusinessAddressPostalCode", BusinessAddressPostalCode);
                        objCommand.Parameters.AddWithValue("@HasPicture", HasPicture);
                        objCommand.Parameters.AddWithValue("@LastModificationTime", LastModificationTime);

                    }

                    objCommand = null;

                }
                catch (Exception ex)
                {
                    logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") " + FileAs + " - ERROR: " + ex.Message);
                    totalErrors++;
                }

                

                //Application.DoEvents();
            }
            objSQLConnection.Close();
            objSQLConnection = null;

            

            logString += objDebugger.LogTextOut("ContactsSync", "errors: " + totalErrors.ToString());
            logString += objDebugger.LogTextOut("ContactsSync", totalrows.ToString() + " total Contacts added.");
            return logString;

        }


        /********************************************************************************************************************/
        /*                                                                                                                  */
        /* 1) IT WILL TAKE ANY NEW RECORDS FROM ContactsOutlookExport TABLE AND INSERT INTO CONTACTS TABLE                  */
        /*                                                                                                                  */
        /* 2) THIS WILL COMPARE THE LastModicationFields IN CONTACT AND ContactsOutlookExport TABLES                        */
        /*                                                                                                                  */
        /* if (ContactsDateTime > ContactsOutlookExportDateTime) THEN                                                       */
        /*              TAKE THE FROM Contacts Table AND UPDATE THE OUTLOOK CONTACT                                         */
        /*                                                                                                                  */
        /* if (ContactsDateTime < ContactsOutlookExportDateTime) THEN                                                        */
        /*              UPDATE Contacts Table FROM CONTACTSOUTLOOKEXPORT TABLE                                               */
        /*                                                                                                                   */
        /***********************************************************************************************************************/
        public string ContactsSync(int UserID)
        {
            logString = string.Empty;
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            logString += objDebugger.LogTextOut("ContactsSync", "ContactsSync");
            logString += objDebugger.LogTextOut("ContactsSync", "**********************************************");
            totalErrors = 0;

            string connection_String = ConfigurationManager.AppSettings["SQLConnectionString"];

            SqlConnection objSQLConnection = new SqlConnection(connection_String);
            objSQLConnection.Open();
            SqlCommand objCommand = new SqlCommand("sp_Contacts_Sync_check", objSQLConnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@UserID", UserID);

            SqlDataReader objDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 1;
            int contactsUpdated = 0;

            if (objDataReader.HasRows)
            {
                while (objDataReader.Read())
                {
                    logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") " + (string)objDataReader["ContactsFileAs"]);
                    DateTime ContactsDateTime = (DateTime)objDataReader["ContactsDateTime"];
                    DateTime ContactsOutlookExportDateTime = (DateTime)objDataReader["ContactsOutlookExportDateTime"];

                    

                    if (ContactsDateTime > ContactsOutlookExportDateTime)
                    {
                        /****************************************
                            UPDATE OUTLOOK CONTACT
                        /****************************************/
                        string ErrorMessage = string.Empty;

                        try
                        {
                            if (SaveOutlookContact
                                (
                                    (string)objDataReader["EntryID"],
                                    (string)objDataReader["ContactsFileAs"],
                                    (string)objDataReader["ContactsFirstName"],
                                    (string)objDataReader["ContactsLastName"],
                                    (string)objDataReader["ContactsFullName"],
                                    (string)objDataReader["ContactsJobTitle"],
                                    (string)objDataReader["ContactsCompanyName"],
                                    (string)objDataReader["ContactsEmail1Address"],
                                    (string)objDataReader["ContactsEmail2Address"],
                                    (string)objDataReader["ContactsEmail3Address"],
                                    (string)objDataReader["ContactsWebPage"],
                                    (string)objDataReader["ContactsIMAddress"],
                                    (string)objDataReader["ContactsMobileTelephoneNumber"],
                                    (string)objDataReader["ContactsHomeTelephoneNumber"],
                                    (string)objDataReader["ContactsBusinessTelephoneNumber"],
                                    (string)objDataReader["ContactsBusinessFaxNumber"],
                                    (string)objDataReader["ContactsHomeAddressStreet"],
                                    (string)objDataReader["ContactsHomeAddressCity"],
                                    (string)objDataReader["ContactsHomeAddressState"],
                                    (string)objDataReader["ContactsHomeAddressPostalCode"],
                                    (string)objDataReader["ContactsBusinessAddressStreet"],
                                    (string)objDataReader["ContactsBusinessAddressCity"],
                                    (string)objDataReader["ContactsBusinessAddressState"],
                                    (string)objDataReader["ContactsBusinessAddressPostalCode"],
                                    ref ErrorMessage
                                )
                                )
                            {
                                contactsUpdated++;
                                logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") Outlook Contact '" + (string)objDataReader["ContactsFileAs"] + "' CREATED");
                            }
                            else
                            {
                                totalErrors++;
                                logString += objDebugger.LogTextOut("ContactsSync", ErrorMessage);
                            }
                        }
                        catch (Exception ex)
                        {
                            logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") " + (string)objDataReader["ContactsFileAs"] + ") - ERROR: " + ex.Message);
                            totalErrors++;
                        }
                    }
                    else
                    {
                        logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") " + ContactsDateTime.ToLongDateString() + " < " + ContactsOutlookExportDateTime.ToLongDateString());
                        try
                        {

                            SqlConnection objSQLConnection2 = new SqlConnection(connection_String);
                            objSQLConnection2.Open();
                            SqlCommand objCommand2 = new SqlCommand("sp_Contacts_update", objSQLConnection2);
                            objCommand2.CommandType = CommandType.StoredProcedure;
                            objCommand2.Parameters.AddWithValue("@ContactID", (int)objDataReader["ContactID"]);
                            objCommand2.Parameters.AddWithValue("@EntryID", (string)objDataReader["EntryID"]);
                            objCommand2.Parameters.AddWithValue("@FileAs", (string)objDataReader["ContactsOutlookExportFileAs"]);
                            objCommand2.Parameters.AddWithValue("@FirstName", (string)objDataReader["ContactsOutlookExportFirstName"]);
                            objCommand2.Parameters.AddWithValue("@LastName", (string)objDataReader["ContactsOutlookExportLastName"]);
                            objCommand2.Parameters.AddWithValue("@FullName", (string)objDataReader["ContactsOutlookExportFullName"]);
                            objCommand2.Parameters.AddWithValue("@CompanyName", (string)objDataReader["ContactsOutlookExportCompanyName"]);
                            objCommand2.Parameters.AddWithValue("@JobTitle", (string)objDataReader["ContactsOutlookExportJobTitle"]);
                            objCommand2.Parameters.AddWithValue("@Email1Address", (string)objDataReader["ContactsOutlookExportEmail1Address"]);
                            objCommand2.Parameters.AddWithValue("@Email2Address", (string)objDataReader["ContactsOutlookExportEmail2Address"]);
                            objCommand2.Parameters.AddWithValue("@Email3Address", (string)objDataReader["ContactsOutlookExportEmail3Address"]);
                            objCommand2.Parameters.AddWithValue("@WebPage", (string)objDataReader["ContactsOutlookExportWebPage"]);
                            objCommand2.Parameters.AddWithValue("@IMAddress", (string)objDataReader["ContactsOutlookExportIMAddress"]);
                            objCommand2.Parameters.AddWithValue("@MobileTelephoneNumber", (string)objDataReader["ContactsOutlookExportMobileTelephoneNumber"]);
                            objCommand2.Parameters.AddWithValue("@HomeTelephoneNumber", (string)objDataReader["ContactsOutlookExportHomeTelephoneNumber"]);
                            objCommand2.Parameters.AddWithValue("@BusinessTelephoneNumber", (string)objDataReader["ContactsOutlookExportBusinessTelephoneNumber"]);
                            objCommand2.Parameters.AddWithValue("@BusinessFaxNumber", (string)objDataReader["ContactsOutlookExportBusinessFaxNumber"]);
                            objCommand2.Parameters.AddWithValue("@HomeAddressStreet", (string)objDataReader["ContactsOutlookExportHomeAddressStreet"]);
                            objCommand2.Parameters.AddWithValue("@HomeAddressCity", (string)objDataReader["ContactsOutlookExportHomeAddressCity"]);
                            objCommand2.Parameters.AddWithValue("@HomeAddressState", (string)objDataReader["ContactsOutlookExportHomeAddressState"]);
                            objCommand2.Parameters.AddWithValue("@HomeAddressPostalCode", (string)objDataReader["ContactsOutlookExportHomeAddressPostalCode"]);
                            objCommand2.Parameters.AddWithValue("@BusinessAddressStreet", (string)objDataReader["ContactsOutlookExportBusinessAddressStreet"]);
                            objCommand2.Parameters.AddWithValue("@BusinessAddressCity", (string)objDataReader["ContactsOutlookExportBusinessAddressCity"]);
                            objCommand2.Parameters.AddWithValue("@BusinessAddressState", (string)objDataReader["ContactsOutlookExportBusinessAddressState"]);
                            objCommand2.Parameters.AddWithValue("@BusinessAddressPostalCode", (string)objDataReader["ContactsOutlookExportBusinessAddressPostalCode"]);
                            objCommand2.Parameters.AddWithValue("@HasPicture", (bool)objDataReader["ContactsOutlookExportHasPicture"]);
                            objCommand2.Parameters.AddWithValue("@LastModificationTime", (DateTime)objDataReader["ContactsOutlookExportDateTime"]);
                            objCommand2.ExecuteNonQuery();
                            objCommand2.Dispose();
                            objCommand2 = null;

                            objSQLConnection2.Close();
                            objSQLConnection2.Dispose();
                            objSQLConnection2 = null;
                            contactsUpdated++;
                            logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") sp_Contacts_update: " + (string)objDataReader["ContactsOutlookExportFileAs"] + " Contact updated.");
                        }
                        catch (Exception ex)
                        {
                            logString += objDebugger.LogTextOut("ContactsSync", i.ToString() + ") - ERROR: " + ex.Message);
                            totalErrors++;
                        }
                    }

                    i++;
                }
                objDataReader.Close();
                objDataReader.Dispose();
                objDataReader = null;
            }
            logString += objDebugger.LogTextOut("ContactsSync", "errors: " + totalErrors.ToString());
            logString += objDebugger.LogTextOut("ContactsSync", contactsUpdated.ToString() + " Contacts updated.");

            return logString;
        }

        /****************************************/
        /* DELETE OUTLOOK CONTACT                */
        /* - pass it OUTLOOK ENTRYID             */
        /****************************************/
        public bool DeleteOutlookContact(string EntryID, ref string ErrorMessage)
        {
            bool boolContactDeleted = true;

            Microsoft.Office.Interop.Outlook.Application outlookApp = new Microsoft.Office.Interop.Outlook.Application();

            Microsoft.Office.Interop.Outlook.MAPIFolder Folder_Contacts = (Microsoft.Office.Interop.Outlook.MAPIFolder)
            outlookApp.Session.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);


            Microsoft.Office.Interop.Outlook.Items searchFolder = Folder_Contacts.Items;
            if (Folder_Contacts.Items.Count > 0)
            {
                foreach (Microsoft.Office.Interop.Outlook.ContactItem contact in searchFolder)
                {
                    if (contact.EntryID.Contains(EntryID))
                    {
                        try
                        {
                            contact.Delete();
                            boolContactDeleted = true;
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage += "ERROR: " + ex.Message + Environment.NewLine;
                            boolContactDeleted = false;
                        }
                    }
                }
            }

            Folder_Contacts = null;
            outlookApp = null;
            return boolContactDeleted;
        }

        /****************************************/
        /* CREATE OUTLOOK CONTACT               */
        /****************************************/
        public bool CreateOutlookContact
                (
                    string EntryID,
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
                    string BusinessAddressPostalCode,
                    ref string ErrorMessage
                )
        {
            bool boolContactAdded = true;

            Microsoft.Office.Interop.Outlook.Application outlookApp = new Microsoft.Office.Interop.Outlook.Application();
            outlookApp.Session.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);

            try
            {
                Microsoft.Office.Interop.Outlook.ContactItem contact = (Outlook.ContactItem)outlookApp.CreateItem(Outlook.OlItemType.olContactItem);

                contact.FileAs = FileAs;
                contact.FirstName = FirstName;
                contact.LastName = LastName;
                contact.FullName = FullName;
                contact.CompanyName = CompanyName;
                contact.JobTitle = JobTitle;
                contact.Email1Address = Email1Address;
                contact.Email2Address = Email2Address;
                contact.Email3Address = Email3Address;
                contact.WebPage = WebPage;
                contact.IMAddress = IMAddress;
                contact.MobileTelephoneNumber = MobileTelephoneNumber;
                contact.HomeTelephoneNumber = HomeTelephoneNumber;
                contact.BusinessTelephoneNumber = BusinessTelephoneNumber;
                contact.BusinessFaxNumber = BusinessFaxNumber;
                contact.HomeAddressStreet = HomeAddressStreet;
                contact.HomeAddressCity = HomeAddressCity;
                contact.HomeAddressState = HomeAddressStateName;
                contact.HomeAddressPostalCode = HomeAddressPostalCode;
                contact.BusinessAddressStreet = BusinessAddressStreet;
                contact.BusinessAddressCity = BusinessAddressCity;
                contact.BusinessAddressState = BusinessAddressStateName;
                contact.BusinessAddressPostalCode = BusinessAddressPostalCode;

                contact.Save();

                contact = null;

                boolContactAdded = true;
            }
            catch (Exception ex)
            {
                ErrorMessage += "ERROR: " + ex.Message + Environment.NewLine;
                boolContactAdded = false;
            }

            outlookApp = null;
            return boolContactAdded;
        }

        /****************************************/
        /* SAVE OUTLOOK CONTACT                */
        /****************************************/
        public bool SaveOutlookContact
                (
                    string EntryID,
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
                    string BusinessAddressPostalCode,
                    ref string ErrorMessage
                )
        {
            bool boolContactUpdated = true;

            Microsoft.Office.Interop.Outlook.Application outlookApp = new Microsoft.Office.Interop.Outlook.Application();

            Outlook.MAPIFolder Folder_Contacts = (Outlook.MAPIFolder)
            outlookApp.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);

            try
            {
                Outlook.Items searchFolder = Folder_Contacts.Items;

                foreach (Microsoft.Office.Interop.Outlook.ContactItem contact in searchFolder)
                {
                    if (contact.EntryID.Contains(EntryID))
                    {
                        contact.FileAs = FileAs;
                        contact.FirstName = FirstName;
                        contact.LastName = LastName;
                        contact.FullName = FullName;
                        contact.CompanyName = CompanyName;
                        contact.JobTitle = JobTitle;
                        contact.Email1Address = Email1Address;
                        contact.Email2Address = Email2Address;
                        contact.Email3Address = Email3Address;
                        contact.WebPage = WebPage;
                        contact.IMAddress = IMAddress;
                        contact.MobileTelephoneNumber = MobileTelephoneNumber;
                        contact.HomeTelephoneNumber = HomeTelephoneNumber;
                        contact.BusinessTelephoneNumber = BusinessTelephoneNumber;
                        contact.BusinessFaxNumber = BusinessFaxNumber;
                        contact.HomeAddressStreet = HomeAddressStreet;
                        contact.HomeAddressCity = HomeAddressCity;
                        contact.HomeAddressState = HomeAddressStateName;
                        contact.HomeAddressPostalCode = HomeAddressPostalCode;
                        contact.BusinessAddressStreet = BusinessAddressStreet;
                        contact.BusinessAddressCity = BusinessAddressCity;
                        contact.BusinessAddressState = BusinessAddressStateName;
                        contact.BusinessAddressPostalCode = BusinessAddressPostalCode;

                        contact.Save();
                    }
                }

                boolContactUpdated = true;
            }
            catch (Exception ex)
            {
                ErrorMessage += "ERROR: " + ex.Message + Environment.NewLine;
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

            Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder contacts = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);

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
                    foreach (Microsoft.Office.Interop.Outlook.Attachment att in contact.Attachments)
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

            app = null;
            ns = null;
            contacts = null;

            return boolGetOutlookContact;
        }


        {
            Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder contacts = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);

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

                foreach (Outlook.ContactItem contact in contacts.Items)
                {
                    entryid = contact.EntryID;
                    fileas = contact.FileAs;
                    table.Rows.Add(entryid, fileas);
                    //results += objDebugger.LogTextOut("ClassLibraryOutlook", x.ToString() + ") " + entryid + " - " + fileas + Environment.NewLine);
                    x++;
                }

                DataView view = table.DefaultView;
                view.Sort = "FileAs ASC";
                DataTable t = view.ToTable(); ;

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
                            bool deleteOutlookContact = DeleteOutlookContact((string)t.Rows[y][0].ToString(), ref ErrorMessage);
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


            app = null;
            ns = null;
            contacts = null;

            return results;
        }
    }
}

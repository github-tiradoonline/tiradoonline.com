using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Pop3;

using tiradoonline.DataAccess.tiradoonline;
using tiradoonline.DataAccess.tiradoonline.Models;

namespace tiradoonline.ClassLibrary
{
    public class clsPOP3
    {
        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();

        public int POP3EmailFolderID = 1001;

        //public List<modelPOP3Email> POPEmailMessages(string hostname, int port, bool useSsl, string username, string password)
        public void POPEmailMessages(string hostname, int port, bool useSsl, string username, string password)
        {
            try
            {
                Pop3Client pop3Client;
                pop3Client = new Pop3Client();
                pop3Client.Connect(hostname, port, useSsl);

                // Authenticate ourselves towards the server
                pop3Client.Authenticate(username, password);

                // Get the number of messages in the inbox
                int messageCount = pop3Client.GetMessageCount();

                Console.WriteLine("Total Emails: " + messageCount.ToString());

                DataTable dtMessages = new DataTable();
                dtMessages.Columns.Add("MessageID");
                dtMessages.Columns.Add("Date");
                dtMessages.Columns.Add("DateSent");
                dtMessages.Columns.Add("FromName");
                dtMessages.Columns.Add("FromEmail");
                dtMessages.Columns.Add("SenderName");
                dtMessages.Columns.Add("SenderEmail");
                dtMessages.Columns.Add("Subject");
                dtMessages.Columns.Add("MessageBodyText");
                //DBDataContext objDB = new DBDataContext();
                modelPOP3Email objPOP3Email = new modelPOP3Email();

                try
                {
                    for (int i = messageCount; i >= 1; i--)
                    {
                        OpenPop.Mime.Message message = pop3Client.GetMessage(i);

                        objPOP3Email.POP3EmailMessageId = message.Headers.MessageId;
                        objPOP3Email.POP3EmailMessageDateTime = message.Headers.Date;
                        objPOP3Email.POP3EmailMessageDateSent = message.Headers.DateSent;
                        objPOP3Email.POP3EmailFromName = message.Headers.From.MailAddress.DisplayName;
                        objPOP3Email.POP3EmailFromEmail = message.Headers.From.MailAddress.Address;
                        objPOP3Email.POP3EmailSubject = message.Headers.Subject;
                        objPOP3Email.listPOP3Email.Add(objPOP3Email);

                        objPOP3Email.POP3EmailBodyText = string.Empty;

                        OpenPop.Mime.MessagePart html = message.FindFirstHtmlVersion();

                        if (html != null)
                        {
                            // Save the plain text to a file, database or anything you like
                            string MessageBodyText = html.GetBodyAsText();
                            //dtMessages.Rows[dtMessages.Rows.Count - 1]["MessageBodyText"] = MessageBodyText;
                            //html.Save(new FileInfo(@"c:\emails\" + message.Headers.MessageId + ".txt"));
                        }

                        //objDB.sp_POP3Email_insert(this.POP3EmailFolderID, MessageID, MessageDateSent, MessageFromName, MessageFromEmail, MessageSubject, MessageBodyText);
                    }
                }
                catch (Exception exc)
                {
                    string eString = exc.ToString();
                    //return null;
                }

                //return dtMessages;
            }
            catch (Exception e)
            {
                string message = e.ToString();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace tiradoonline.ClassLibrary
{
    public class clsLogs
    {
        public static bool LogToTextFile = false;
        public static bool LogToEmail = false;
        public static bool LogToEventLog = false;
        public static bool LogToDatabase = false;

        public static void Log(string logApplication, string logDirectory, string logText)
        {
            StringBuilder objString = new StringBuilder();
            string logFile = string.Format(@"{0}\{1}-{2}-{3}.txt", logDirectory, DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), DateTime.Now.Year.ToString());
            objString.AppendLine("Date:");
            objString.AppendLine("-------------------------------");
            objString.AppendLine(DateTime.Now.ToString() + Environment.NewLine);
            objString.AppendLine("Application:");
            objString.AppendLine("--------------------------------------------------------------");
            objString.AppendLine(logApplication + Environment.NewLine);
            objString.AppendLine("Log File:");
            objString.AppendLine("--------------------------------------------------------------");
            objString.AppendLine(logFile + Environment.NewLine);
            objString.AppendLine("Error:");
            objString.AppendLine("--------------------------------------------------------------");
            objString.AppendLine(logText + Environment.NewLine);
            objString.AppendLine("--------------------------------------------------------------");
            logText = objString.ToString();
            objString = null;

            // **************************************************
            // WRITE TO TEXT FILE
            // **************************************************
            if (LogToTextFile)
                clsIO.WriteFile(logFile, logText + clsIO.ReadFile(logFile));



            // **************************************************
            // SEND EMAIL
            // **************************************************
            if (LogToEmail) {
                string subject = string.Format("Error: {0}", logApplication);
                clsNetworking objNetworking = new clsNetworking();
                objNetworking.STMP(clsConfiguration.AdministratorName, clsConfiguration.LogsEmail, clsConfiguration.AdministratorName, clsConfiguration.AdministratorEmail, subject, "<pre>" + logText + "</pre>");
                objNetworking = null;
            }



            
             //**************************************************
             //WRITE TO EVENT LOG
             //**************************************************
            if(LogToEventLog)
            {
                string sSource = logApplication;
                string sLog = logApplication;
                if (!EventLog.SourceExists(sSource))
                    EventLog.CreateEventSource(sSource, sLog);

                EventLog.WriteEntry(sSource, logText);
                EventLog.WriteEntry(sSource, logText, EventLogEntryType.Warning, 234);
            }


            
            // **************************************************
            // WRITE TO tiradoonline..Logs TABLE
            // **************************************************
            //if (LogToDatabase)
            //{
            //    dbdatacontext db = new dbdatacontext();
            //    db.sp_logs_insert(logapplication, logtext);
            //    db = null;
            //}
        }
    }
}

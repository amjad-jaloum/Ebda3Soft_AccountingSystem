using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem_DataAccess
{
    internal class clsEventLog
    {
        private const string EventSource = "Ebda3Soft_AccountingSystem";
        private const string EventLogName = "Application";

        public static void LogException(Exception ex)
        {
            try
            {
                if (!EventLog.SourceExists(EventSource))
                {
                    EventLog.CreateEventSource(EventSource, EventLogName);
                }
                EventLog.WriteEntry(EventSource, ex.ToString(), EventLogEntryType.Error);
            }
            catch (Exception logEx)
            {
                LogToFile(ex, logEx);
            }
        }

        private static void LogToFile(Exception PrimaryEx, Exception FallbackEx)
        {
            try
            {
                // accessing 'c:/program data' witch has write permission in standard mode user
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Ebda3Soft");
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                string logFilePath = Path.Combine(filePath, "ErrorLog.txt");

                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("-----------------");
                    writer.WriteLine($"{DateTime.Now}: {FallbackEx.Message}");
                    writer.WriteLine($"Primary Exception: {PrimaryEx}");
                }
            }
            catch { }
        }
    }
}

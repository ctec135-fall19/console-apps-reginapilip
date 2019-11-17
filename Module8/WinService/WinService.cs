using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinService
{
    public partial class WinService : ServiceBase
    {
        public WinService()
        {
            InitializeComponent(); 
            if (!EventLog.SourceExists("WinService"))
            {
                EventLog.CreateEventSource("WinService", "Application");
            }
            eventLog1.Source = "WinService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Starting the Service.", 
                EventLogEntryType.Information, 1001);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopping the Service.",
                EventLogEntryType.Information, 1001);
        }

        protected override void OnPause()
        {
            eventLog1.WriteEntry("Pausing the Service.",
                EventLogEntryType.Information, 1001);
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Continuing the Service.",
                EventLogEntryType.Information, 1001);
        }

        protected override void OnShutdown()
        {
            eventLog1.WriteEntry("Shutting Down the Service.",
                EventLogEntryType.Information, 1001);
        }
    }
}

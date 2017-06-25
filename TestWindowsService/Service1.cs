using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            eventLog1 = new EventLog();
            if (!EventLog.SourceExists("TestService"))
            {
                EventLog.CreateEventSource("TestService", "TestServiceLog");
            }
            eventLog1.Source = "TestService";
            eventLog1.Log = "TestServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart for good service");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop for good service");
        }
    }
}

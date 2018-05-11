using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Runtime.InteropServices;

namespace Duy.EventTasks
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideAutoLoad(UIContextGuids80.SolutionBuilding)]
    [Guid(PackageGuidString)]
    public class EventTasksPackage : Package
    {
        public const string PackageGuidString = "5F2B8A8A-3E7D-4D51-8C30-F38F79145E79";

        // http://stackoverflow.com/questions/32593610/what-is-the-correct-way-to-subscribe-to-the-envdte80-dte2-events2-publishevents
        private DTE2 application;
        private Events2 events;
        private PublishEvents publishEvents;

        protected override void Initialize()
        {
            base.Initialize();

            application = (DTE2)GetService(typeof(DTE));
            events = (Events2)application.Events;
            publishEvents = events.PublishEvents;

            publishEvents.OnPublishBegin += PublishEvents_OnPublishBegin;
            publishEvents.OnPublishDone += PublishEvents_OnPublishDone;
        }

        private void PublishEvents_OnPublishDone(bool Success)
        {

        }

        private void PublishEvents_OnPublishBegin(ref bool Continue)
        {

        }
    }
}

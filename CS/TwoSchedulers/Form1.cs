using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace TwoSchedulers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                schedulerStorage1.Resources.Add(new Resource(i, "Res" + i.ToString()));
        }

        private void schedulerControl1_VisibleIntervalChanged(object sender, EventArgs e)
        {
            SetStart(schedulerControl2, schedulerControl1);            
        }

        private void schedulerControl2_VisibleIntervalChanged(object sender, EventArgs e)
        {
            SetStart(schedulerControl1, schedulerControl2);            
        }

        private static void SetStart(SchedulerControl firstScheduler, SchedulerControl secondScheduler)
        {
            firstScheduler.Start = secondScheduler.Start;
        }
        
        private void schedulerControl1_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e)
        {
            SetFirstVisibleResourceIndex(schedulerControl2, schedulerControl1);
            SetResourcesPerPage(schedulerControl2, schedulerControl1);
        }

        private void schedulerControl2_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e)
        {
            SetFirstVisibleResourceIndex(schedulerControl1, schedulerControl2);
            SetResourcesPerPage(schedulerControl1, schedulerControl2);
        }

        private static void SetFirstVisibleResourceIndex(SchedulerControl firstScheduler, SchedulerControl secondScheduler)
        {
            if (firstScheduler.ActiveView.FirstVisibleResourceIndex != secondScheduler.ActiveView.FirstVisibleResourceIndex)
                firstScheduler.ActiveView.FirstVisibleResourceIndex = secondScheduler.ActiveView.FirstVisibleResourceIndex;
        }

        private static void SetResourcesPerPage(SchedulerControl firstScheduler, SchedulerControl secondScheduler)
        { 
            if(firstScheduler.ActiveView.ResourcesPerPage != secondScheduler.ActiveView.ResourcesPerPage)
                firstScheduler.ActiveView.ResourcesPerPage = secondScheduler.ActiveView.ResourcesPerPage;
        }
    }
}

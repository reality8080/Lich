using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;
using System.Xml.Serialization;

namespace Calender
{
    public partial class DailyPlant : Form
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }
        FlowLayoutPanel fPanel;

        public DailyPlant(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;

            // Initialize fPanel only once
            fPanel = new FlowLayoutPanel
            {
                Width = pnlJob.Width,
                Height = pnlJob.Height
            };

            pnlJob.Controls.Add(fPanel);

            dtpkDate.Value = Date;

            // Show jobs for the selected date immediately
            ShowJob(Date);
        }

        List<PlanItem> GetJobbyDate(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year &&
                                      p.Date.Month == date.Month &&
                                      p.Date.Day == date.Day).ToList();
        }

        void jobItem_Edited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void jobItem_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem jobItem = uc.Job;
            fPanel.Controls.Remove(uc); // Remove the control from the UI
            Job.Job.Remove(jobItem);
        }

        void ShowJob(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobbyDate(date);
                for(int i= 0; i < todayJob.Count; i++)
                {
                    AJob aJob = new AJob(todayJob[i]);
                    aJob.Edited += AJob_Edited;
                    aJob.Deleted += AJob_Deleted;
                    fPanel.Controls.Add(aJob);
                }
            }
        }
        void Addjob(PlanItem jobItem)
        {
            AJob aJob = new AJob(jobItem);
            aJob.Edited += AJob_Edited; // Subscribe to the edited event
            aJob.Deleted += AJob_Deleted; // Subscribe to the deleted event
            fPanel.Controls.Add(aJob);

        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJob((sender as DateTimePicker).Value);
        }

        private void DailyPlant_Load(object sender, EventArgs e)
        {
            // You can initialize or load any other data here if needed
        }

        private void TomorrowdayButton_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void YesterdayButton_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        // Event handler for when a job is edited (not yet implemented)
        void AJob_Edited(object sender, EventArgs e)
        {
          
        }

        // Event handler for when a job is deleted
        void AJob_Deleted(object sender, EventArgs e)
        {
            // Remove the job from the list and the UI
            AJob uc = sender as AJob;
            PlanItem jobItem = uc.Job;
            fPanel.Controls.Remove(uc); // Remove the control from the UI
            Job.Job.Remove(jobItem);    // Remove the job item from the list
        }

        private void thêmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };
            Job.Job.Add(item);
            Addjob(item);
        }

        private void hômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }
        private string filePath = "data";
        private void lưuViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeToXML(Job, filePath);
            // lưu text Job

            

        }
        public void SerializeToXML(object data, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                sr.Serialize(fs, data);
            }
        }
    }
}

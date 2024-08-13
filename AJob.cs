using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }
        public AJob(PlanItem job)
        {
            InitializeComponent();
            cbStatus.DataSource = PlanItem.ListStatus;
            this.Job = job;
            ShowInfo();
            

        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        void ShowInfo()
        {
            JobTextbox.Text = Job.Job;
            nmFromHour.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHour.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            int statusIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            if (statusIndex >= 0 && statusIndex < cbStatus.Items.Count)
            {
                cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
                cbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
            }
            else
            {
                // Handle the case where the status is not found
                cbStatus.SelectedIndex = -1; // or any default value
            }
            cbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }
        private void RepairButton_Click(object sender, EventArgs e)
        {
            Job.Job = JobTextbox.Text;
            Job.FromTime = new Point((int)nmFromHour.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHour.Value, (int)nmToMinute.Value);

            if (cbStatus.SelectedIndex >= 0 && cbStatus.SelectedIndex < PlanItem.ListStatus.Count)
            {
                Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];
                setcolor();
            }
            else
            {
                // Handle the case where the selected index is invalid
                MessageBox.Show("Please select a valid status.");
            }

            if (edited != null)
                edited(this, new EventArgs());
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if(deleted != null )
                deleted(this,new EventArgs());
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Items.Count > 0)
            {
                cbStatus.SelectedIndex = cbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
            }
            else
            {
                // Handle the case where the ComboBox is not populated
                MessageBox.Show("Status ComboBox is not populated.");
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show status
            cbDone.Checked = cbStatus.SelectedIndex == (int)EPlanItem.DONE ? true : false;
        }
        // Add a new method to update the status
        public void UpdateStatus(string status)
        {
            int statusIndex = PlanItem.ListStatus.IndexOf(status);
            if (statusIndex >= 0 && statusIndex < cbStatus.Items.Count)
            {
                cbStatus.SelectedIndex = statusIndex;
                cbDone.Checked = statusIndex == (int)EPlanItem.DONE ? true : false;
            }
            else
            {
                // Handle the case where the status is not found
                cbStatus.SelectedIndex = -1; // or any default value
            }
        }
        void setcolor()
        {
            if (cbStatus.SelectedIndex == (int)EPlanItem.DONE)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calender
{
    public partial class Form1 : Form
    {
        #region Properties
        NotifyIcon Notify;
        private string filePath = "C:\\Users\\HP\\source\\repos\\Lich\\bin\\Debug\\data.xml";
        private List<List<Button>> matrix;
        public int Apptime;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }
        private List<string> DateofWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        public Form1()
        {
            InitializeComponent();

            Notify = new NotifyIcon();
            numericUpDown1.Value = Cons.notifyTime;
            Apptime = 0;
            LoadMatrix();

            // Nạp dữ liệu từ file
            Job = DeserializeFromXML(filePath) as PlanData;

            if (Job == null)
            {
                // Nếu không có dữ liệu, tạo dữ liệu mặc định
                setDefaultJob();
            }
        }

        void setDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Testing",
                Status = PlanItem.ListStatus[(int)EPlanItem.DONE]
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };

            for (int i = 0; i < Cons.DayOfCollumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.ButtonW, Height = Cons.ButtonH };
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width, OldBtn.Location.Y);
                    btn.Click += Btn_Click;
                    PanelMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, OldBtn.Location.Y + Cons.ButtonH) };
            }
            SetDefaultDate();
        }

        void Btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "")
                return;

            DailyPlant daily = new DailyPlant(
                new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)),
                Job);
            daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0))
                        return 29;
                    else
                        return 28;
                default:
                    return 31;
            }
        }

        void AddNumberIntoMatrix(DateTime date)
        {
            DateTime userDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(userDate); i++)
            {
                int column = DateofWeek.IndexOf(userDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (userDate.Day == DateTime.Now.Day && userDate.Month == DateTime.Now.Month && userDate.Year == DateTime.Now.Year)
                {
                    btn.BackColor = Color.Aqua;
                }
                else
                {
                    btn.BackColor = Color.White;
                }

                if (userDate.Day == dtpkDate.Value.Day && userDate.Month == dtpkDate.Value.Month && userDate.Year == dtpkDate.Value.Year)
                {
                    btn.BackColor = Color.Yellow;
                }

                if (column >= 6)
                    line++;

                userDate = userDate.AddDays(1);
            }
        }

        void ClearValueMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ClearValueMatrix();
            AddNumberIntoMatrix((sender as DateTimePicker).Value);
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void Today_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        public void SerializeToXML(object data, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                    sr.Serialize(fs, data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during serialization: " + ex.Message);
            }
        }

        private object DeserializeFromXML(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found: " + path);
                return null;
            }

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                    return sr.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deserialization: " + ex.Message);
                return null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Job == null || Job.Job == null)
            {
                MessageBox.Show("No data to save.");
                return;
            }

            SerializeToXML(Job, filePath);
        }

        // Notify time
        private void timer1_Tick(object sender, EventArgs e)
        {
            Apptime++;
            if (Apptime < Cons.notifyTime)
            {
                return;
            }
            if (Job == null || Job.Job == null)
            {
                return;
            }

            List<PlanItem> todayJobs = Job.Job.Where(p => p.Date.Year == DateTime.Now.Year &&
                                                       p.Date.Month == DateTime.Now.Month &&
                                                       p.Date.Day == DateTime.Now.Day).ToList();
            Notify.ShowBalloonTip(Cons.notifyTimeOut, "Lich cong viec", "", ToolTipIcon.Info);
            Apptime = 0;
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)numericUpDown1.Value;
        }

        private void NotifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = NotifyCheckBox.Checked;
        }
    }
}

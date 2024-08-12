//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Calender
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class Form1 : Form
    {
        #region Peoperties
        private List<List<Button>> matrix;
        public List<List<Button>>Matrix
        {

            get { return matrix; } 
            set{matrix =value; }
        }
        private List<string> dateOfWeek = new List<string>(){ "Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};//Dang code.............
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
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
                    PanelMatrix.Controls.Add(btn);
                    OldBtn = btn;
                    Matrix[i].Add(btn);
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, OldBtn.Location.Y + Cons.ButtonH) };
            }
            SetDefaultDate();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        return 31;
                    }
                case 2:
                    {
                        if (date.Year % 4 == 0 && date.Month % 100 != 0)
                        {
                            return 29;
                        }
                        else
                        {
                            return 28;
                        }
                    }
                default:return 30; ;
            }
        }
        void HamNgayThangNam(DateTime ngay)
        {
            DateTime useDate = new DateTime(ngay.Year, ngay.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(ngay); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }
        void SetDefaultDate()
        {
            dateTimePicker.Value = DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            HamNgayThangNam((sender as DateTimePicker).Value);

        }
    }
}
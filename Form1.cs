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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void LoadMatrix()
        {
            Button OldBtn=new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for(int i = 0; i < Cons.DayOfCollumn; i++)
            {
                for(int j=0;j< Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width=Cons.ButtonW,Height=Cons.ButtonH};
                    btn.Location = new Point(OldBtn.Location.X+OldBtn.Width,OldBtn.Location.Y);
                    PanelMatrix.Controls.Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, OldBtn.Location.Y+Cons.ButtonH) };
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}

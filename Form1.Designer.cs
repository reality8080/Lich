namespace Calender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonWed = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonThurs = new System.Windows.Forms.Button();
            this.buttonFri = new System.Windows.Forms.Button();
            this.buttonTues = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Today = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PanelMatrix);
            this.panel4.Location = new System.Drawing.Point(0, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 525);
            this.panel4.TabIndex = 2;
            // 
            // PanelMatrix
            // 
            this.PanelMatrix.Location = new System.Drawing.Point(172, 6);
            this.PanelMatrix.Name = "PanelMatrix";
            this.PanelMatrix.Size = new System.Drawing.Size(718, 519);
            this.PanelMatrix.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(2, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 80);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonSun);
            this.panel6.Controls.Add(this.buttonWed);
            this.panel6.Controls.Add(this.NextMonthButton);
            this.panel6.Controls.Add(this.buttonSat);
            this.panel6.Controls.Add(this.PreviousMonthButton);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.buttonThurs);
            this.panel6.Controls.Add(this.buttonFri);
            this.panel6.Controls.Add(this.buttonTues);
            this.panel6.Location = new System.Drawing.Point(-2, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1063, 76);
            this.panel6.TabIndex = 0;
            // 
            // buttonSun
            // 
            this.buttonSun.Location = new System.Drawing.Point(790, 14);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(84, 56);
            this.buttonSun.TabIndex = 14;
            this.buttonSun.Text = "CN";
            this.buttonSun.UseVisualStyleBackColor = true;
            // 
            // buttonWed
            // 
            this.buttonWed.Location = new System.Drawing.Point(383, 14);
            this.buttonWed.Name = "buttonWed";
            this.buttonWed.Size = new System.Drawing.Size(84, 56);
            this.buttonWed.TabIndex = 10;
            this.buttonWed.Text = "Thứ 4";
            this.buttonWed.UseVisualStyleBackColor = true;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Location = new System.Drawing.Point(985, 14);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(73, 56);
            this.NextMonthButton.TabIndex = 8;
            this.NextMonthButton.Text = "Tháng sau";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // buttonSat
            // 
            this.buttonSat.Location = new System.Drawing.Point(687, 14);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(84, 56);
            this.buttonSat.TabIndex = 13;
            this.buttonSat.Text = "Thứ 7";
            this.buttonSat.UseVisualStyleBackColor = true;
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.Location = new System.Drawing.Point(5, 14);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(73, 56);
            this.PreviousMonthButton.TabIndex = 7;
            this.PreviousMonthButton.Text = "Tháng trước";
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            this.PreviousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 56);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thứ 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonThurs
            // 
            this.buttonThurs.Location = new System.Drawing.Point(484, 14);
            this.buttonThurs.Name = "buttonThurs";
            this.buttonThurs.Size = new System.Drawing.Size(84, 56);
            this.buttonThurs.TabIndex = 11;
            this.buttonThurs.Text = "Thứ 5";
            this.buttonThurs.UseVisualStyleBackColor = true;
            // 
            // buttonFri
            // 
            this.buttonFri.Location = new System.Drawing.Point(586, 14);
            this.buttonFri.Name = "buttonFri";
            this.buttonFri.Size = new System.Drawing.Size(84, 56);
            this.buttonFri.TabIndex = 12;
            this.buttonFri.Text = "Thứ 6";
            this.buttonFri.UseVisualStyleBackColor = true;
            // 
            // buttonTues
            // 
            this.buttonTues.Location = new System.Drawing.Point(281, 14);
            this.buttonTues.Name = "buttonTues";
            this.buttonTues.Size = new System.Drawing.Size(84, 56);
            this.buttonTues.TabIndex = 9;
            this.buttonTues.Text = "Thứ 3";
            this.buttonTues.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Today);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 63);
            this.panel2.TabIndex = 0;
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(705, 19);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(93, 25);
            this.Today.TabIndex = 2;
            this.Today.Text = "Hôm nay";
            this.Today.UseVisualStyleBackColor = true;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(399, 20);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(267, 22);
            this.dtpkDate.TabIndex = 1;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Controls.Add(this.NotifyCheckBox);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 58);
            this.panel5.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // NotifyCheckBox
            // 
            this.NotifyCheckBox.AutoSize = true;
            this.NotifyCheckBox.Location = new System.Drawing.Point(6, 21);
            this.NotifyCheckBox.Name = "NotifyCheckBox";
            this.NotifyCheckBox.Size = new System.Drawing.Size(63, 20);
            this.NotifyCheckBox.TabIndex = 0;
            this.NotifyCheckBox.Text = "Notify";
            this.NotifyCheckBox.UseVisualStyleBackColor = true;
            this.NotifyCheckBox.CheckedChanged += new System.EventHandler(this.NotifyCheckBox_CheckedChanged);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 60000;
            // 
            // timer1
            // 
//            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 673);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox NotifyCheckBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PanelMatrix;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button buttonSun;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Button buttonFri;
        private System.Windows.Forms.Button buttonWed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonTues;
        private System.Windows.Forms.Button buttonThurs;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.Timer timer1;
    }
}


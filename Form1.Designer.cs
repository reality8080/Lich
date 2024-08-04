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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.buttonFri = new System.Windows.Forms.Button();
            this.buttonThurs = new System.Windows.Forms.Button();
            this.buttonWeds = new System.Windows.Forms.Button();
            this.buttonTues = new System.Windows.Forms.Button();
            this.buttonMon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Today = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
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
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(0, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 525);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(258, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 519);
            this.panel7.TabIndex = 0;
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
            this.panel6.Controls.Add(this.NextMonthButton);
            this.panel6.Controls.Add(this.PreviousMonthButton);
            this.panel6.Controls.Add(this.buttonSun);
            this.panel6.Controls.Add(this.buttonSat);
            this.panel6.Controls.Add(this.buttonFri);
            this.panel6.Controls.Add(this.buttonThurs);
            this.panel6.Controls.Add(this.buttonWeds);
            this.panel6.Controls.Add(this.buttonTues);
            this.panel6.Controls.Add(this.buttonMon);
            this.panel6.Location = new System.Drawing.Point(-2, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1063, 76);
            this.panel6.TabIndex = 0;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Location = new System.Drawing.Point(985, 14);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(73, 56);
            this.NextMonthButton.TabIndex = 8;
            this.NextMonthButton.Text = "Tháng sau";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.Location = new System.Drawing.Point(5, 14);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(73, 56);
            this.PreviousMonthButton.TabIndex = 7;
            this.PreviousMonthButton.Text = "Tháng trước";
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            // 
            // buttonSun
            // 
            this.buttonSun.Location = new System.Drawing.Point(732, 17);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(73, 56);
            this.buttonSun.TabIndex = 6;
            this.buttonSun.Text = "Chủ Nhật";
            this.buttonSun.UseVisualStyleBackColor = true;
            // 
            // buttonSat
            // 
            this.buttonSat.Location = new System.Drawing.Point(653, 17);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(73, 56);
            this.buttonSat.TabIndex = 5;
            this.buttonSat.Text = "Thứ 7";
            this.buttonSat.UseVisualStyleBackColor = true;
            // 
            // buttonFri
            // 
            this.buttonFri.Location = new System.Drawing.Point(574, 17);
            this.buttonFri.Name = "buttonFri";
            this.buttonFri.Size = new System.Drawing.Size(73, 56);
            this.buttonFri.TabIndex = 4;
            this.buttonFri.Text = "Thứ 6";
            this.buttonFri.UseVisualStyleBackColor = true;
            // 
            // buttonThurs
            // 
            this.buttonThurs.Location = new System.Drawing.Point(495, 17);
            this.buttonThurs.Name = "buttonThurs";
            this.buttonThurs.Size = new System.Drawing.Size(73, 56);
            this.buttonThurs.TabIndex = 3;
            this.buttonThurs.Text = "Thứ 5";
            this.buttonThurs.UseVisualStyleBackColor = true;
            // 
            // buttonWeds
            // 
            this.buttonWeds.Location = new System.Drawing.Point(416, 17);
            this.buttonWeds.Name = "buttonWeds";
            this.buttonWeds.Size = new System.Drawing.Size(73, 56);
            this.buttonWeds.TabIndex = 2;
            this.buttonWeds.Text = "Thứ 4";
            this.buttonWeds.UseVisualStyleBackColor = true;
            // 
            // buttonTues
            // 
            this.buttonTues.Location = new System.Drawing.Point(337, 17);
            this.buttonTues.Name = "buttonTues";
            this.buttonTues.Size = new System.Drawing.Size(73, 56);
            this.buttonTues.TabIndex = 1;
            this.buttonTues.Text = "Thứ 3";
            this.buttonTues.UseVisualStyleBackColor = true;
            // 
            // buttonMon
            // 
            this.buttonMon.Location = new System.Drawing.Point(258, 17);
            this.buttonMon.Name = "buttonMon";
            this.buttonMon.Size = new System.Drawing.Size(73, 56);
            this.buttonMon.TabIndex = 0;
            this.buttonMon.Text = "Thứ 2";
            this.buttonMon.UseVisualStyleBackColor = true;
            this.buttonMon.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Today);
            this.panel2.Controls.Add(this.dateTimePicker1);
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
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.dateTimePicker1.TabIndex = 1;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 673);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox NotifyCheckBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Button buttonFri;
        private System.Windows.Forms.Button buttonThurs;
        private System.Windows.Forms.Button buttonWeds;
        private System.Windows.Forms.Button buttonTues;
        private System.Windows.Forms.Button buttonMon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button buttonSun;
    }
}


﻿namespace Calender
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Today = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel6.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(2, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 80);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(0, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 525);
            this.panel4.TabIndex = 2;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.dateTimePicker1.TabIndex = 1;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.NextMonthButton);
            this.panel6.Controls.Add(this.PreviousMonthButton);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(-2, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1063, 76);
            this.panel6.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(574, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(653, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(732, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 56);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(258, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 519);
            this.panel7.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 673);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button button7;
    }
}


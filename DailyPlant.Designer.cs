﻿namespace Calender
{
    partial class DailyPlant
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.YesterdayButton = new System.Windows.Forms.Button();
            this.TomorrowdayButton = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 679);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(2, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 68);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.YesterdayButton);
            this.panel6.Controls.Add(this.TomorrowdayButton);
            this.panel6.Controls.Add(this.dtpkDate);
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1133, 64);
            this.panel6.TabIndex = 0;
            // 
            // YesterdayButton
            // 
            this.YesterdayButton.Location = new System.Drawing.Point(97, 20);
            this.YesterdayButton.Name = "YesterdayButton";
            this.YesterdayButton.Size = new System.Drawing.Size(113, 25);
            this.YesterdayButton.TabIndex = 2;
            this.YesterdayButton.Text = "Hôm qua";
            this.YesterdayButton.UseVisualStyleBackColor = true;
            this.YesterdayButton.Click += new System.EventHandler(this.YesterdayButton_Click);
            // 
            // TomorrowdayButton
            // 
            this.TomorrowdayButton.Location = new System.Drawing.Point(919, 18);
            this.TomorrowdayButton.Name = "TomorrowdayButton";
            this.TomorrowdayButton.Size = new System.Drawing.Size(113, 25);
            this.TomorrowdayButton.TabIndex = 1;
            this.TomorrowdayButton.Text = "Ngày mai";
            this.TomorrowdayButton.UseVisualStyleBackColor = true;
            this.TomorrowdayButton.Click += new System.EventHandler(this.TomorrowdayButton_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(427, 23);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(283, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlJob);
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 621);
            this.panel3.TabIndex = 1;
            // 
            // pnlJob
            // 
            this.pnlJob.AutoScroll = true;
            this.pnlJob.AutoSize = true;
            this.pnlJob.Location = new System.Drawing.Point(3, 59);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(1133, 561);
            this.pnlJob.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 40);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmViệcToolStripMenuItem,
            this.hômNayToolStripMenuItem,
            this.lưuViệcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmViệcToolStripMenuItem
            // 
            this.thêmViệcToolStripMenuItem.Name = "thêmViệcToolStripMenuItem";
            this.thêmViệcToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.thêmViệcToolStripMenuItem.Text = "Thêm Việc";
            this.thêmViệcToolStripMenuItem.Click += new System.EventHandler(this.thêmViệcToolStripMenuItem_Click);
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hômNayToolStripMenuItem.Text = "Hôm nay";
            this.hômNayToolStripMenuItem.Click += new System.EventHandler(this.hômNayToolStripMenuItem_Click);
            // 
            // lưuViệcToolStripMenuItem
            // 
            this.lưuViệcToolStripMenuItem.Name = "lưuViệcToolStripMenuItem";
            this.lưuViệcToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.lưuViệcToolStripMenuItem.Text = "Lưu việc";
            this.lưuViệcToolStripMenuItem.Click += new System.EventHandler(this.lưuViệcToolStripMenuItem_Click);
            // 
            // DailyPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 673);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DailyPlant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPlant";
            this.Load += new System.EventHandler(this.DailyPlant_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button YesterdayButton;
        private System.Windows.Forms.Button TomorrowdayButton;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.ToolStripMenuItem thêmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hômNayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuViệcToolStripMenuItem;
    }
}
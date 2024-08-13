namespace Calender
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.EraseButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmFromHour = new System.Windows.Forms.NumericUpDown();
            this.JobTextbox = new System.Windows.Forms.TextBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.EraseButton);
            this.panel1.Controls.Add(this.RepairButton);
            this.panel1.Controls.Add(this.nmToMinute);
            this.panel1.Controls.Add(this.nmToHour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmFromMinute);
            this.panel1.Controls.Add(this.nmFromHour);
            this.panel1.Controls.Add(this.JobTextbox);
            this.panel1.Controls.Add(this.cbDone);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 52);
            this.panel1.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(787, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 24);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(1003, 11);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(55, 32);
            this.EraseButton.TabIndex = 8;
            this.EraseButton.Text = "Xóa";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.Location = new System.Drawing.Point(942, 11);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(55, 32);
            this.RepairButton.TabIndex = 7;
            this.RepairButton.Text = "Sửa";
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(735, 16);
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(39, 22);
            this.nmToMinute.TabIndex = 6;
            // 
            // nmToHour
            // 
            this.nmToHour.Location = new System.Drawing.Point(686, 16);
            this.nmToHour.Name = "nmToHour";
            this.nmToHour.Size = new System.Drawing.Size(43, 22);
            this.nmToHour.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // nmFromMinute
            // 
            this.nmFromMinute.Location = new System.Drawing.Point(604, 16);
            this.nmFromMinute.Name = "nmFromMinute";
            this.nmFromMinute.Size = new System.Drawing.Size(39, 22);
            this.nmFromMinute.TabIndex = 3;
            // 
            // nmFromHour
            // 
            this.nmFromHour.Location = new System.Drawing.Point(555, 16);
            this.nmFromHour.Name = "nmFromHour";
            this.nmFromHour.Size = new System.Drawing.Size(43, 22);
            this.nmFromHour.TabIndex = 2;
            // 
            // JobTextbox
            // 
            this.JobTextbox.Location = new System.Drawing.Point(47, 27);
            this.JobTextbox.Name = "JobTextbox";
            this.JobTextbox.Size = new System.Drawing.Size(487, 22);
            this.JobTextbox.TabIndex = 1;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(23, 19);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(18, 17);
            this.cbDone.TabIndex = 0;
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.CheckedChanged += new System.EventHandler(this.cbDone_CheckedChanged);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(1081, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
        private System.Windows.Forms.NumericUpDown nmFromHour;
        private System.Windows.Forms.TextBox JobTextbox;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}

namespace DogCare
{
    partial class frmReportSchedule
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvClasses = new System.Windows.Forms.ListView();
            this.chClassDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVariety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvAttendees = new System.Windows.Forms.ListView();
            this.chClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 69);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Class schedule";
            // 
            // lsvClasses
            // 
            this.lsvClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chClassDate,
            this.chStartTime,
            this.chEndTime,
            this.chVariety,
            this.chProgramName,
            this.chStaffName});
            this.lsvClasses.Location = new System.Drawing.Point(52, 156);
            this.lsvClasses.Name = "lsvClasses";
            this.lsvClasses.Size = new System.Drawing.Size(598, 515);
            this.lsvClasses.TabIndex = 33;
            this.lsvClasses.UseCompatibleStateImageBehavior = false;
            this.lsvClasses.View = System.Windows.Forms.View.Details;
            this.lsvClasses.SelectedIndexChanged += new System.EventHandler(this.lsvClasses_SelectedIndexChanged);
            // 
            // chClassDate
            // 
            this.chClassDate.Text = "Class Date";
            // 
            // chStartTime
            // 
            this.chStartTime.Text = "Start time";
            // 
            // chEndTime
            // 
            this.chEndTime.Text = "End time";
            // 
            // chVariety
            // 
            this.chVariety.Text = "Variety";
            // 
            // chProgramName
            // 
            this.chProgramName.Text = "Program name";
            // 
            // chStaffName
            // 
            this.chStaffName.Text = "Staff name";
            // 
            // lsvAttendees
            // 
            this.lsvAttendees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chClientName,
            this.chDogName});
            this.lsvAttendees.Location = new System.Drawing.Point(682, 156);
            this.lsvAttendees.Name = "lsvAttendees";
            this.lsvAttendees.Size = new System.Drawing.Size(428, 514);
            this.lsvAttendees.TabIndex = 34;
            this.lsvAttendees.UseCompatibleStateImageBehavior = false;
            this.lsvAttendees.View = System.Windows.Forms.View.Details;
            // 
            // chClientName
            // 
            this.chClientName.Text = "Client name";
            // 
            // chDogName
            // 
            this.chDogName.Text = "Dog name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Upcoming classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Attendees";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(956, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 58);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(46, 674);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(332, 24);
            this.lblHelp.TabIndex = 38;
            this.lblHelp.Text = "Tap on the class date to see attendees";
            // 
            // frmReportSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvAttendees);
            this.Controls.Add(this.lsvClasses);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmReportSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportSchedule";
            this.Load += new System.EventHandler(this.frmReportSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvClasses;
        private System.Windows.Forms.ListView lsvAttendees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader chClassDate;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.ColumnHeader chVariety;
        private System.Windows.Forms.ColumnHeader chProgramName;
        private System.Windows.Forms.ColumnHeader chStaffName;
        private System.Windows.Forms.ColumnHeader chClientName;
        private System.Windows.Forms.ColumnHeader chDogName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHelp;
    }
}
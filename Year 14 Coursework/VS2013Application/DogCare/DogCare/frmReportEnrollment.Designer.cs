namespace DogCare
{
    partial class frmReportEnrollment
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvClasses = new System.Windows.Forms.ListView();
            this.chPogramName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramVarietyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstClassDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberEnrolled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxSpaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFreeSpaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(998, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 58);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 69);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Enrollment";
            // 
            // lsvClasses
            // 
            this.lsvClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPogramName,
            this.chProgramVarietyName,
            this.chFirstClassDate,
            this.chNumberEnrolled,
            this.chMaxSpaces,
            this.chFreeSpaces});
            this.lsvClasses.Location = new System.Drawing.Point(52, 156);
            this.lsvClasses.Name = "lsvClasses";
            this.lsvClasses.Size = new System.Drawing.Size(831, 515);
            this.lsvClasses.TabIndex = 37;
            this.lsvClasses.UseCompatibleStateImageBehavior = false;
            this.lsvClasses.View = System.Windows.Forms.View.Details;
            this.lsvClasses.SelectedIndexChanged += new System.EventHandler(this.lsvClasses_SelectedIndexChanged);
            // 
            // chPogramName
            // 
            this.chPogramName.Text = "Program name";
            // 
            // chProgramVarietyName
            // 
            this.chProgramVarietyName.Text = "Program variety name";
            // 
            // chFirstClassDate
            // 
            this.chFirstClassDate.Text = "First class date";
            // 
            // chNumberEnrolled
            // 
            this.chNumberEnrolled.Text = "Number enrolled";
            // 
            // chMaxSpaces
            // 
            this.chMaxSpaces.Text = "Max spaces";
            // 
            // chFreeSpaces
            // 
            this.chFreeSpaces.Text = "Free spaces";
            // 
            // frmReportEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvClasses);
            this.Name = "frmReportEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportEnrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvClasses;
        private System.Windows.Forms.ColumnHeader chPogramName;
        private System.Windows.Forms.ColumnHeader chProgramVarietyName;
        private System.Windows.Forms.ColumnHeader chFirstClassDate;
        private System.Windows.Forms.ColumnHeader chNumberEnrolled;
        private System.Windows.Forms.ColumnHeader chMaxSpaces;
        private System.Windows.Forms.ColumnHeader chFreeSpaces;
    }
}
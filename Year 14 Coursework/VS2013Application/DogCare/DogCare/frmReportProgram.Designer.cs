namespace DogCare
{
    partial class frmReportProgram
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
            this.chProgramVariety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNoOfClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberOfClassesArranged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMissingClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(998, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 58);
            this.btnBack.TabIndex = 42;
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
            this.lblTitle.Size = new System.Drawing.Size(259, 69);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Program";
            // 
            // lsvClasses
            // 
            this.lsvClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPogramName,
            this.chProgramVariety,
            this.chNoOfClasses,
            this.chNumberOfClassesArranged,
            this.chMissingClasses});
            this.lsvClasses.Location = new System.Drawing.Point(52, 156);
            this.lsvClasses.Name = "lsvClasses";
            this.lsvClasses.Size = new System.Drawing.Size(831, 515);
            this.lsvClasses.TabIndex = 40;
            this.lsvClasses.UseCompatibleStateImageBehavior = false;
            this.lsvClasses.View = System.Windows.Forms.View.Details;
            // 
            // chPogramName
            // 
            this.chPogramName.Text = "Program name";
            // 
            // chProgramVariety
            // 
            this.chProgramVariety.Text = "Program variety";
            // 
            // chNoOfClasses
            // 
            this.chNoOfClasses.Text = "Max spaces";
            // 
            // chNumberOfClassesArranged
            // 
            this.chNumberOfClassesArranged.Text = "Number of classes arranged";
            // 
            // chMissingClasses
            // 
            this.chMissingClasses.Text = "Missing classes";
            // 
            // frmReportProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvClasses);
            this.Name = "frmReportProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvClasses;
        private System.Windows.Forms.ColumnHeader chPogramName;
        private System.Windows.Forms.ColumnHeader chProgramVariety;
        private System.Windows.Forms.ColumnHeader chNumberOfClassesArranged;
        private System.Windows.Forms.ColumnHeader chMissingClasses;
        private System.Windows.Forms.ColumnHeader chNoOfClasses;
    }
}
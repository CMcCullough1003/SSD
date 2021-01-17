namespace DogCare
{
    partial class frmReportBilling
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
            this.lsvClasses = new System.Windows.Forms.ListView();
            this.chClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmountDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDaysOverdue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentRecieved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvClasses
            // 
            this.lsvClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chClientName,
            this.chPaymentType,
            this.chAmountDue,
            this.chDueDate,
            this.chDaysOverdue,
            this.chPaymentRecieved,
            this.chProgramName});
            this.lsvClasses.Location = new System.Drawing.Point(52, 156);
            this.lsvClasses.Name = "lsvClasses";
            this.lsvClasses.Size = new System.Drawing.Size(831, 515);
            this.lsvClasses.TabIndex = 34;
            this.lsvClasses.UseCompatibleStateImageBehavior = false;
            this.lsvClasses.View = System.Windows.Forms.View.Details;
            this.lsvClasses.SelectedIndexChanged += new System.EventHandler(this.lsvClasses_SelectedIndexChanged);
            // 
            // chClientName
            // 
            this.chClientName.Text = "Client name";
            // 
            // chPaymentType
            // 
            this.chPaymentType.Text = "Payment Type";
            // 
            // chAmountDue
            // 
            this.chAmountDue.Text = "Amount due";
            // 
            // chDueDate
            // 
            this.chDueDate.Text = "Due date";
            // 
            // chDaysOverdue
            // 
            this.chDaysOverdue.Text = "Days overdue";
            // 
            // chPaymentRecieved
            // 
            this.chPaymentRecieved.Text = "Payment recieved";
            // 
            // chProgramName
            // 
            this.chProgramName.Text = "Program name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 69);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Billing";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(998, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 58);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReportBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvClasses);
            this.Name = "frmReportBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportBilling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvClasses;
        private System.Windows.Forms.ColumnHeader chClientName;
        private System.Windows.Forms.ColumnHeader chPaymentType;
        private System.Windows.Forms.ColumnHeader chAmountDue;
        private System.Windows.Forms.ColumnHeader chDueDate;
        private System.Windows.Forms.ColumnHeader chPaymentRecieved;
        private System.Windows.Forms.ColumnHeader chProgramName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ColumnHeader chDaysOverdue;
        private System.Windows.Forms.Button btnBack;
    }
}
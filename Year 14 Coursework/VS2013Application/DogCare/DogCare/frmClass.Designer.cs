namespace DogCare
{
    partial class frmClass
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
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.cbxProgram = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.lsvClass = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClassDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(523, 270);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(164, 24);
            this.cbxStaff.TabIndex = 71;
            this.cbxStaff.Text = "Please select";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(520, 250);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(42, 17);
            this.lblStaff.TabIndex = 70;
            this.lblStaff.Text = "Staff";
            // 
            // cbxProgram
            // 
            this.cbxProgram.FormattingEnabled = true;
            this.cbxProgram.Location = new System.Drawing.Point(523, 214);
            this.cbxProgram.Name = "cbxProgram";
            this.cbxProgram.Size = new System.Drawing.Size(164, 24);
            this.cbxProgram.TabIndex = 69;
            this.cbxProgram.Text = "Please select";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(520, 194);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(69, 17);
            this.lblProgram.TabIndex = 64;
            this.lblProgram.Text = "Program";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(520, 151);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 63;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(520, 125);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 17);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "Class ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(711, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(45, 501);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 59;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(40, 81);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(77, 29);
            this.lblClass.TabIndex = 58;
            this.lblClass.Text = "Class";
            // 
            // lsvClass
            // 
            this.lsvClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chProgram,
            this.chStaff,
            this.chClassDate,
            this.chStartTime,
            this.chEndTime});
            this.lsvClass.FullRowSelect = true;
            this.lsvClass.GridLines = true;
            this.lsvClass.Location = new System.Drawing.Point(45, 125);
            this.lsvClass.Name = "lsvClass";
            this.lsvClass.Size = new System.Drawing.Size(424, 355);
            this.lsvClass.TabIndex = 57;
            this.lsvClass.UseCompatibleStateImageBehavior = false;
            this.lsvClass.View = System.Windows.Forms.View.Details;
            this.lsvClass.SelectedIndexChanged += new System.EventHandler(this.lsvClass_SelectedIndexChanged_1);
            // 
            // chID
            // 
            this.chID.Text = "Class ID";
            this.chID.Width = 80;
            // 
            // chProgram
            // 
            this.chProgram.Text = "Program";
            this.chProgram.Width = 76;
            // 
            // chStaff
            // 
            this.chStaff.Text = "Staff";
            // 
            // chClassDate
            // 
            this.chClassDate.Text = "Date";
            // 
            // chStartTime
            // 
            this.chStartTime.Text = "Start time";
            // 
            // chEndTime
            // 
            this.chEndTime.Text = "End time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(523, 439);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(164, 22);
            this.txtEndTime.TabIndex = 73;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(523, 324);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 22);
            this.txtDate.TabIndex = 66;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(520, 361);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(78, 17);
            this.lblStartTime.TabIndex = 67;
            this.lblStartTime.Text = "Start time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(523, 381);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(164, 22);
            this.txtStartTime.TabIndex = 68;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(520, 419);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(71, 17);
            this.lblEndTime.TabIndex = 72;
            this.lblEndTime.Text = "End time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(520, 304);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "Date";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(711, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 29);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 611);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cbxStaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.cbxProgram);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblIDReadOnly);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lsvClass);
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.ComboBox cbxProgram;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListView lsvClass;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chProgram;
        private System.Windows.Forms.ColumnHeader chStaff;
        private System.Windows.Forms.ColumnHeader chClassDate;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBack;
    }
}
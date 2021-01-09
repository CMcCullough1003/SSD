namespace DogCare
{
    partial class frmProgram
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
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvProgram = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramVariety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxProgramVariety = new System.Windows.Forms.ComboBox();
            this.lblProgramVariety = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(567, 173);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(567, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 17);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "Program ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(570, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(92, 523);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 39;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 29);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Program";
            // 
            // lsvProgram
            // 
            this.lsvProgram.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chProgramVariety});
            this.lsvProgram.FullRowSelect = true;
            this.lsvProgram.GridLines = true;
            this.lsvProgram.Location = new System.Drawing.Point(92, 147);
            this.lsvProgram.Name = "lsvProgram";
            this.lsvProgram.Size = new System.Drawing.Size(424, 355);
            this.lsvProgram.TabIndex = 37;
            this.lsvProgram.UseCompatibleStateImageBehavior = false;
            this.lsvProgram.View = System.Windows.Forms.View.Details;
            this.lsvProgram.SelectedIndexChanged += new System.EventHandler(this.lsvProgram_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "Program ID";
            this.chID.Width = 80;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chProgramVariety
            // 
            this.chProgramVariety.Text = "ProgramVariety";
            // 
            // cbxProgramVariety
            // 
            this.cbxProgramVariety.FormattingEnabled = true;
            this.cbxProgramVariety.Location = new System.Drawing.Point(570, 289);
            this.cbxProgramVariety.Name = "cbxProgramVariety";
            this.cbxProgramVariety.Size = new System.Drawing.Size(164, 24);
            this.cbxProgramVariety.TabIndex = 56;
            this.cbxProgramVariety.Text = "Please select";
            // 
            // lblProgramVariety
            // 
            this.lblProgramVariety.AutoSize = true;
            this.lblProgramVariety.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramVariety.Location = new System.Drawing.Point(567, 269);
            this.lblProgramVariety.Name = "lblProgramVariety";
            this.lblProgramVariety.Size = new System.Drawing.Size(123, 17);
            this.lblProgramVariety.TabIndex = 55;
            this.lblProgramVariety.Text = "Program variety";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(567, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(570, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 101;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(758, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 29);
            this.btnBack.TabIndex = 102;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 655);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxProgramVariety);
            this.Controls.Add(this.lblProgramVariety);
            this.Controls.Add(this.lblIDReadOnly);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvProgram);
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvProgram;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chProgramVariety;
        private System.Windows.Forms.ComboBox cbxProgramVariety;
        private System.Windows.Forms.Label lblProgramVariety;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBack;
    }
}
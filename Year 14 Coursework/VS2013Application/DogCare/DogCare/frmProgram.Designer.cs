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
            this.cbxProgramType = new System.Windows.Forms.ComboBox();
            this.txtNumberOfClasses = new System.Windows.Forms.TextBox();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.txtMaximumSpaces = new System.Windows.Forms.TextBox();
            this.lblMaximumSpaces = new System.Windows.Forms.Label();
            this.lblProgramType = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvProgram = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgramCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaximumSpaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberOfClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxProgramCost = new System.Windows.Forms.ComboBox();
            this.lblProgramCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxProgramType
            // 
            this.cbxProgramType.FormattingEnabled = true;
            this.cbxProgramType.Location = new System.Drawing.Point(570, 287);
            this.cbxProgramType.Name = "cbxProgramType";
            this.cbxProgramType.Size = new System.Drawing.Size(164, 24);
            this.cbxProgramType.TabIndex = 52;
            this.cbxProgramType.Text = "Please select";
            // 
            // txtNumberOfClasses
            // 
            this.txtNumberOfClasses.Location = new System.Drawing.Point(570, 454);
            this.txtNumberOfClasses.Name = "txtNumberOfClasses";
            this.txtNumberOfClasses.Size = new System.Drawing.Size(164, 22);
            this.txtNumberOfClasses.TabIndex = 50;
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfClasses.Location = new System.Drawing.Point(567, 434);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(111, 17);
            this.lblNumberOfClasses.TabIndex = 49;
            this.lblNumberOfClasses.Text = "No. of classes";
            // 
            // txtMaximumSpaces
            // 
            this.txtMaximumSpaces.Location = new System.Drawing.Point(570, 397);
            this.txtMaximumSpaces.Name = "txtMaximumSpaces";
            this.txtMaximumSpaces.Size = new System.Drawing.Size(164, 22);
            this.txtMaximumSpaces.TabIndex = 48;
            // 
            // lblMaximumSpaces
            // 
            this.lblMaximumSpaces.AutoSize = true;
            this.lblMaximumSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumSpaces.Location = new System.Drawing.Point(567, 377);
            this.lblMaximumSpaces.Name = "lblMaximumSpaces";
            this.lblMaximumSpaces.Size = new System.Drawing.Size(129, 17);
            this.lblMaximumSpaces.TabIndex = 47;
            this.lblMaximumSpaces.Text = "Maximum spaces";
            // 
            // lblProgramType
            // 
            this.lblProgramType.AutoSize = true;
            this.lblProgramType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramType.Location = new System.Drawing.Point(567, 267);
            this.lblProgramType.Name = "lblProgramType";
            this.lblProgramType.Size = new System.Drawing.Size(105, 17);
            this.lblProgramType.TabIndex = 44;
            this.lblProgramType.Text = "Program type";
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
            this.chProgramType,
            this.chProgramCost,
            this.chMaximumSpaces,
            this.chNumberOfClasses});
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
            // chProgramType
            // 
            this.chProgramType.Text = "Program Type";
            this.chProgramType.Width = 76;
            // 
            // chProgramCost
            // 
            this.chProgramCost.Text = "ProgramCost";
            // 
            // chMaximumSpaces
            // 
            this.chMaximumSpaces.Text = "Maximum Spaces";
            // 
            // chNumberOfClasses
            // 
            this.chNumberOfClasses.Text = "No. of Classes";
            // 
            // cbxProgramCost
            // 
            this.cbxProgramCost.FormattingEnabled = true;
            this.cbxProgramCost.Location = new System.Drawing.Point(570, 343);
            this.cbxProgramCost.Name = "cbxProgramCost";
            this.cbxProgramCost.Size = new System.Drawing.Size(164, 24);
            this.cbxProgramCost.TabIndex = 56;
            this.cbxProgramCost.Text = "Please select";
            // 
            // lblProgramCost
            // 
            this.lblProgramCost.AutoSize = true;
            this.lblProgramCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramCost.Location = new System.Drawing.Point(567, 323);
            this.lblProgramCost.Name = "lblProgramCost";
            this.lblProgramCost.Size = new System.Drawing.Size(104, 17);
            this.lblProgramCost.TabIndex = 55;
            this.lblProgramCost.Text = "Program cost";
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
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(570, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 58;
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 655);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxProgramCost);
            this.Controls.Add(this.lblProgramCost);
            this.Controls.Add(this.cbxProgramType);
            this.Controls.Add(this.txtNumberOfClasses);
            this.Controls.Add(this.lblNumberOfClasses);
            this.Controls.Add(this.txtMaximumSpaces);
            this.Controls.Add(this.lblMaximumSpaces);
            this.Controls.Add(this.lblProgramType);
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

        private System.Windows.Forms.ComboBox cbxProgramType;
        private System.Windows.Forms.TextBox txtNumberOfClasses;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.TextBox txtMaximumSpaces;
        private System.Windows.Forms.Label lblMaximumSpaces;
        private System.Windows.Forms.Label lblProgramType;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvProgram;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chProgramType;
        private System.Windows.Forms.ColumnHeader chProgramCost;
        private System.Windows.Forms.ColumnHeader chMaximumSpaces;
        private System.Windows.Forms.ColumnHeader chNumberOfClasses;
        private System.Windows.Forms.ComboBox cbxProgramCost;
        private System.Windows.Forms.Label lblProgramCost;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}
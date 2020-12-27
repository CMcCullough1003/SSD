namespace DogCare
{
    partial class frmProgramCost
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
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvProgramCost = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepositAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSessionCost = new System.Windows.Forms.TextBox();
            this.lblSessionCost = new System.Windows.Forms.Label();
            this.txtPercentageDiscount = new System.Windows.Forms.TextBox();
            this.lblPercentageDiscount = new System.Windows.Forms.Label();
            this.chSessionCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPercentageDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(571, 271);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(164, 22);
            this.txtDepositAmount.TabIndex = 26;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(568, 251);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(122, 17);
            this.lblDepositAmount.TabIndex = 25;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(568, 208);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(568, 182);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 17);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ProgramCost ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(759, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(571, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(93, 558);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(88, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 29);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "ProgramType";
            // 
            // lsvProgramCost
            // 
            this.lsvProgramCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chDepositAmount,
            this.chSessionCost,
            this.chPercentageDiscount});
            this.lsvProgramCost.FullRowSelect = true;
            this.lsvProgramCost.GridLines = true;
            this.lsvProgramCost.Location = new System.Drawing.Point(93, 182);
            this.lsvProgramCost.Name = "lsvProgramCost";
            this.lsvProgramCost.Size = new System.Drawing.Size(396, 355);
            this.lsvProgramCost.TabIndex = 18;
            this.lsvProgramCost.UseCompatibleStateImageBehavior = false;
            this.lsvProgramCost.View = System.Windows.Forms.View.Details;
            this.lsvProgramCost.SelectedIndexChanged += new System.EventHandler(this.lsvProgramCost_SelectedIndexChanged_1);
            // 
            // chID
            // 
            this.chID.Text = "ProgramCost ID";
            this.chID.Width = 80;
            // 
            // chDepositAmount
            // 
            this.chDepositAmount.Text = "Deposit Amount";
            this.chDepositAmount.Width = 120;
            // 
            // txtSessionCost
            // 
            this.txtSessionCost.Location = new System.Drawing.Point(571, 324);
            this.txtSessionCost.Name = "txtSessionCost";
            this.txtSessionCost.Size = new System.Drawing.Size(164, 22);
            this.txtSessionCost.TabIndex = 28;
            // 
            // lblSessionCost
            // 
            this.lblSessionCost.AutoSize = true;
            this.lblSessionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCost.Location = new System.Drawing.Point(568, 304);
            this.lblSessionCost.Name = "lblSessionCost";
            this.lblSessionCost.Size = new System.Drawing.Size(102, 17);
            this.lblSessionCost.TabIndex = 27;
            this.lblSessionCost.Text = "Session Cost";
            // 
            // txtPercentageDiscount
            // 
            this.txtPercentageDiscount.Location = new System.Drawing.Point(571, 382);
            this.txtPercentageDiscount.Name = "txtPercentageDiscount";
            this.txtPercentageDiscount.Size = new System.Drawing.Size(164, 22);
            this.txtPercentageDiscount.TabIndex = 30;
            // 
            // lblPercentageDiscount
            // 
            this.lblPercentageDiscount.AutoSize = true;
            this.lblPercentageDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageDiscount.Location = new System.Drawing.Point(568, 362);
            this.lblPercentageDiscount.Name = "lblPercentageDiscount";
            this.lblPercentageDiscount.Size = new System.Drawing.Size(159, 17);
            this.lblPercentageDiscount.TabIndex = 29;
            this.lblPercentageDiscount.Text = "Percentage Discount";
            // 
            // chSessionCost
            // 
            this.chSessionCost.Text = "Session Cost";
            // 
            // chPercentageDiscount
            // 
            this.chPercentageDiscount.Text = "PercentageDiscount";
            // 
            // frmProgramCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 724);
            this.Controls.Add(this.txtPercentageDiscount);
            this.Controls.Add(this.lblPercentageDiscount);
            this.Controls.Add(this.txtSessionCost);
            this.Controls.Add(this.lblSessionCost);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.lblIDReadOnly);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvProgramCost);
            this.Name = "frmProgramCost";
            this.Text = "frmProgramCost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvProgramCost;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDepositAmount;
        private System.Windows.Forms.TextBox txtSessionCost;
        private System.Windows.Forms.Label lblSessionCost;
        private System.Windows.Forms.TextBox txtPercentageDiscount;
        private System.Windows.Forms.Label lblPercentageDiscount;
        private System.Windows.Forms.ColumnHeader chSessionCost;
        private System.Windows.Forms.ColumnHeader chPercentageDiscount;
    }
}
namespace DogCare
{
    partial class frmProgramVariety
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
            this.lblVariety = new System.Windows.Forms.Label();
            this.txtPercentageDiscount = new System.Windows.Forms.TextBox();
            this.lblPercentageDiscount = new System.Windows.Forms.Label();
            this.txtSessionCost = new System.Windows.Forms.TextBox();
            this.lblSessionCost = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvProgramVariety = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVariety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepositAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSessionCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPercentageDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxDogs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberOfClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtnAdvanced = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.txtMaximumNumberOfDogs = new System.Windows.Forms.TextBox();
            this.lblMaximumNumberOfDogs = new System.Windows.Forms.Label();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxNumberOfClasses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVariety
            // 
            this.lblVariety.AutoSize = true;
            this.lblVariety.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariety.Location = new System.Drawing.Point(590, 167);
            this.lblVariety.Name = "lblVariety";
            this.lblVariety.Size = new System.Drawing.Size(59, 17);
            this.lblVariety.TabIndex = 46;
            this.lblVariety.Text = "Variety";
            // 
            // txtPercentageDiscount
            // 
            this.txtPercentageDiscount.Location = new System.Drawing.Point(593, 355);
            this.txtPercentageDiscount.Name = "txtPercentageDiscount";
            this.txtPercentageDiscount.Size = new System.Drawing.Size(164, 22);
            this.txtPercentageDiscount.TabIndex = 45;
            // 
            // lblPercentageDiscount
            // 
            this.lblPercentageDiscount.AutoSize = true;
            this.lblPercentageDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageDiscount.Location = new System.Drawing.Point(590, 335);
            this.lblPercentageDiscount.Name = "lblPercentageDiscount";
            this.lblPercentageDiscount.Size = new System.Drawing.Size(187, 17);
            this.lblPercentageDiscount.TabIndex = 44;
            this.lblPercentageDiscount.Text = "Full Payment % Discount";
            // 
            // txtSessionCost
            // 
            this.txtSessionCost.Location = new System.Drawing.Point(593, 297);
            this.txtSessionCost.Name = "txtSessionCost";
            this.txtSessionCost.Size = new System.Drawing.Size(164, 22);
            this.txtSessionCost.TabIndex = 43;
            // 
            // lblSessionCost
            // 
            this.lblSessionCost.AutoSize = true;
            this.lblSessionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCost.Location = new System.Drawing.Point(590, 277);
            this.lblSessionCost.Name = "lblSessionCost";
            this.lblSessionCost.Size = new System.Drawing.Size(102, 17);
            this.lblSessionCost.TabIndex = 42;
            this.lblSessionCost.Text = "Session Cost";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(593, 244);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(164, 22);
            this.txtDepositAmount.TabIndex = 41;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(590, 224);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(122, 17);
            this.lblDepositAmount.TabIndex = 40;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(590, 143);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 39;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(587, 117);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(140, 17);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ProgramVariety ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(781, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(589, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(115, 510);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(110, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 29);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Program Variety";
            // 
            // lsvProgramVariety
            // 
            this.lsvProgramVariety.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chVariety,
            this.chDepositAmount,
            this.chSessionCost,
            this.chPercentageDiscount,
            this.chMaxDogs,
            this.chNumberOfClasses});
            this.lsvProgramVariety.FullRowSelect = true;
            this.lsvProgramVariety.GridLines = true;
            this.lsvProgramVariety.Location = new System.Drawing.Point(115, 134);
            this.lsvProgramVariety.Name = "lsvProgramVariety";
            this.lsvProgramVariety.Size = new System.Drawing.Size(396, 355);
            this.lsvProgramVariety.TabIndex = 33;
            this.lsvProgramVariety.UseCompatibleStateImageBehavior = false;
            this.lsvProgramVariety.View = System.Windows.Forms.View.Details;
            this.lsvProgramVariety.SelectedIndexChanged += new System.EventHandler(this.lsvProgramCost_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ProgramCost ID";
            this.chID.Width = 80;
            // 
            // chVariety
            // 
            this.chVariety.Text = "Variety";
            // 
            // chDepositAmount
            // 
            this.chDepositAmount.Text = "Deposit Amount";
            this.chDepositAmount.Width = 120;
            // 
            // chSessionCost
            // 
            this.chSessionCost.Text = "Session Cost";
            // 
            // chPercentageDiscount
            // 
            this.chPercentageDiscount.Text = "Full Payment % Discount";
            // 
            // chMaxDogs
            // 
            this.chMaxDogs.Text = "Max. Dogs";
            // 
            // chNumberOfClasses
            // 
            this.chNumberOfClasses.Text = "Number of Classes";
            // 
            // rbtnAdvanced
            // 
            this.rbtnAdvanced.AutoSize = true;
            this.rbtnAdvanced.Location = new System.Drawing.Point(678, 187);
            this.rbtnAdvanced.Name = "rbtnAdvanced";
            this.rbtnAdvanced.Size = new System.Drawing.Size(92, 21);
            this.rbtnAdvanced.TabIndex = 113;
            this.rbtnAdvanced.TabStop = true;
            this.rbtnAdvanced.Text = "Advanced";
            this.rbtnAdvanced.UseVisualStyleBackColor = true;
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(593, 187);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(79, 21);
            this.rbtnRegular.TabIndex = 112;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // txtMaximumNumberOfDogs
            // 
            this.txtMaximumNumberOfDogs.Location = new System.Drawing.Point(593, 462);
            this.txtMaximumNumberOfDogs.Name = "txtMaximumNumberOfDogs";
            this.txtMaximumNumberOfDogs.Size = new System.Drawing.Size(164, 22);
            this.txtMaximumNumberOfDogs.TabIndex = 117;
            // 
            // lblMaximumNumberOfDogs
            // 
            this.lblMaximumNumberOfDogs.AutoSize = true;
            this.lblMaximumNumberOfDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumNumberOfDogs.Location = new System.Drawing.Point(590, 442);
            this.lblMaximumNumberOfDogs.Name = "lblMaximumNumberOfDogs";
            this.lblMaximumNumberOfDogs.Size = new System.Drawing.Size(195, 17);
            this.lblMaximumNumberOfDogs.TabIndex = 116;
            this.lblMaximumNumberOfDogs.Text = "Maximum Number of Dogs";
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfClasses.Location = new System.Drawing.Point(590, 384);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(144, 17);
            this.lblNumberOfClasses.TabIndex = 114;
            this.lblNumberOfClasses.Text = "Number of Classes";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(781, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 29);
            this.btnBack.TabIndex = 118;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbxNumberOfClasses
            // 
            this.cbxNumberOfClasses.FormattingEnabled = true;
            this.cbxNumberOfClasses.Location = new System.Drawing.Point(593, 404);
            this.cbxNumberOfClasses.Name = "cbxNumberOfClasses";
            this.cbxNumberOfClasses.Size = new System.Drawing.Size(164, 24);
            this.cbxNumberOfClasses.TabIndex = 119;
            // 
            // frmProgramVariety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 628);
            this.Controls.Add(this.cbxNumberOfClasses);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMaximumNumberOfDogs);
            this.Controls.Add(this.lblMaximumNumberOfDogs);
            this.Controls.Add(this.lblNumberOfClasses);
            this.Controls.Add(this.rbtnAdvanced);
            this.Controls.Add(this.rbtnRegular);
            this.Controls.Add(this.lblVariety);
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
            this.Controls.Add(this.lsvProgramVariety);
            this.Name = "frmProgramVariety";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgramCosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariety;
        private System.Windows.Forms.TextBox txtPercentageDiscount;
        private System.Windows.Forms.Label lblPercentageDiscount;
        private System.Windows.Forms.TextBox txtSessionCost;
        private System.Windows.Forms.Label lblSessionCost;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvProgramVariety;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chVariety;
        private System.Windows.Forms.ColumnHeader chDepositAmount;
        private System.Windows.Forms.ColumnHeader chSessionCost;
        private System.Windows.Forms.ColumnHeader chPercentageDiscount;
        private System.Windows.Forms.RadioButton rbtnAdvanced;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.TextBox txtMaximumNumberOfDogs;
        private System.Windows.Forms.Label lblMaximumNumberOfDogs;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.ColumnHeader chMaxDogs;
        private System.Windows.Forms.ColumnHeader chNumberOfClasses;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbxNumberOfClasses;
    }
}
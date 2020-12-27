namespace DogCare
{
    partial class frmProgramCosts
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
            this.txtOffer = new System.Windows.Forms.TextBox();
            this.lblOffer = new System.Windows.Forms.Label();
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
            this.lsvProgramCost = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOffer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepositAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSessionCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPercentageDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtOffer
            // 
            this.txtOffer.Location = new System.Drawing.Point(593, 220);
            this.txtOffer.Name = "txtOffer";
            this.txtOffer.Size = new System.Drawing.Size(164, 22);
            this.txtOffer.TabIndex = 47;
            // 
            // lblOffer
            // 
            this.lblOffer.AutoSize = true;
            this.lblOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffer.Location = new System.Drawing.Point(590, 200);
            this.lblOffer.Name = "lblOffer";
            this.lblOffer.Size = new System.Drawing.Size(45, 17);
            this.lblOffer.TabIndex = 46;
            this.lblOffer.Text = "Offer";
            // 
            // txtPercentageDiscount
            // 
            this.txtPercentageDiscount.Location = new System.Drawing.Point(593, 388);
            this.txtPercentageDiscount.Name = "txtPercentageDiscount";
            this.txtPercentageDiscount.Size = new System.Drawing.Size(164, 22);
            this.txtPercentageDiscount.TabIndex = 45;
            // 
            // lblPercentageDiscount
            // 
            this.lblPercentageDiscount.AutoSize = true;
            this.lblPercentageDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageDiscount.Location = new System.Drawing.Point(590, 368);
            this.lblPercentageDiscount.Name = "lblPercentageDiscount";
            this.lblPercentageDiscount.Size = new System.Drawing.Size(159, 17);
            this.lblPercentageDiscount.TabIndex = 44;
            this.lblPercentageDiscount.Text = "Percentage Discount";
            // 
            // txtSessionCost
            // 
            this.txtSessionCost.Location = new System.Drawing.Point(593, 330);
            this.txtSessionCost.Name = "txtSessionCost";
            this.txtSessionCost.Size = new System.Drawing.Size(164, 22);
            this.txtSessionCost.TabIndex = 43;
            // 
            // lblSessionCost
            // 
            this.lblSessionCost.AutoSize = true;
            this.lblSessionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCost.Location = new System.Drawing.Point(590, 310);
            this.lblSessionCost.Name = "lblSessionCost";
            this.lblSessionCost.Size = new System.Drawing.Size(102, 17);
            this.lblSessionCost.TabIndex = 42;
            this.lblSessionCost.Text = "Session Cost";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(593, 277);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(164, 22);
            this.txtDepositAmount.TabIndex = 41;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(590, 257);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(122, 17);
            this.lblDepositAmount.TabIndex = 40;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(590, 160);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 39;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(590, 134);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 17);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ProgramCost ID";
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
            this.btnSave.Location = new System.Drawing.Point(593, 510);
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
            this.lblTitle.Size = new System.Drawing.Size(169, 29);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Program Cost";
            // 
            // lsvProgramCost
            // 
            this.lsvProgramCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chOffer,
            this.chDepositAmount,
            this.chSessionCost,
            this.chPercentageDiscount});
            this.lsvProgramCost.FullRowSelect = true;
            this.lsvProgramCost.GridLines = true;
            this.lsvProgramCost.Location = new System.Drawing.Point(115, 134);
            this.lsvProgramCost.Name = "lsvProgramCost";
            this.lsvProgramCost.Size = new System.Drawing.Size(396, 355);
            this.lsvProgramCost.TabIndex = 33;
            this.lsvProgramCost.UseCompatibleStateImageBehavior = false;
            this.lsvProgramCost.View = System.Windows.Forms.View.Details;
            this.lsvProgramCost.SelectedIndexChanged += new System.EventHandler(this.lsvProgramCost_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ProgramCost ID";
            this.chID.Width = 80;
            // 
            // chOffer
            // 
            this.chOffer.Text = "Offer";
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
            this.chPercentageDiscount.Text = "PercentageDiscount";
            // 
            // frmProgramCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 628);
            this.Controls.Add(this.txtOffer);
            this.Controls.Add(this.lblOffer);
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
            this.Name = "frmProgramCosts";
            this.Text = "frmProgramCosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOffer;
        private System.Windows.Forms.Label lblOffer;
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
        private System.Windows.Forms.ListView lsvProgramCost;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chOffer;
        private System.Windows.Forms.ColumnHeader chDepositAmount;
        private System.Windows.Forms.ColumnHeader chSessionCost;
        private System.Windows.Forms.ColumnHeader chPercentageDiscount;
    }
}
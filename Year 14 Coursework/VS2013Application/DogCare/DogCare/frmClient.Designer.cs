namespace DogCare
{
    partial class frmClient
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
            this.mstCustomer = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayCareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileGroomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbForename = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lsvClient = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClientIDRead = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.mstCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstCustomer
            // 
            this.mstCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dayCareToolStripMenuItem,
            this.kennelToolStripMenuItem,
            this.walkingToolStripMenuItem,
            this.trainingToolStripMenuItem,
            this.groomingToolStripMenuItem,
            this.mobileGroomingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mstCustomer.Location = new System.Drawing.Point(0, 0);
            this.mstCustomer.Name = "mstCustomer";
            this.mstCustomer.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mstCustomer.Size = new System.Drawing.Size(1285, 28);
            this.mstCustomer.TabIndex = 1;
            this.mstCustomer.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dayCareToolStripMenuItem
            // 
            this.dayCareToolStripMenuItem.Name = "dayCareToolStripMenuItem";
            this.dayCareToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.dayCareToolStripMenuItem.Text = "Day Care";
            // 
            // kennelToolStripMenuItem
            // 
            this.kennelToolStripMenuItem.Name = "kennelToolStripMenuItem";
            this.kennelToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.kennelToolStripMenuItem.Text = "Kennel";
            // 
            // walkingToolStripMenuItem
            // 
            this.walkingToolStripMenuItem.Name = "walkingToolStripMenuItem";
            this.walkingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.walkingToolStripMenuItem.Text = "Walking";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // groomingToolStripMenuItem
            // 
            this.groomingToolStripMenuItem.Name = "groomingToolStripMenuItem";
            this.groomingToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.groomingToolStripMenuItem.Text = "Grooming";
            // 
            // mobileGroomingToolStripMenuItem
            // 
            this.mobileGroomingToolStripMenuItem.Name = "mobileGroomingToolStripMenuItem";
            this.mobileGroomingToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.mobileGroomingToolStripMenuItem.Text = "Mobile Grooming";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(185, 449);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(433, 58);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNewClient_Click_1);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(439, 379);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(179, 30);
            this.txbEmail.TabIndex = 27;
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(439, 332);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(179, 30);
            this.txbPhone.TabIndex = 26;
            // 
            // txbForename
            // 
            this.txbForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbForename.Location = new System.Drawing.Point(439, 224);
            this.txbForename.Margin = new System.Windows.Forms.Padding(4);
            this.txbForename.Name = "txbForename";
            this.txbForename.Size = new System.Drawing.Size(179, 30);
            this.txbForename.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(471, 91);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 58);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(185, 514);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(433, 58);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(185, 580);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(433, 58);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // lsvClient
            // 
            this.lsvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Phone,
            this.Email});
            this.lsvClient.Location = new System.Drawing.Point(653, 91);
            this.lsvClient.Margin = new System.Windows.Forms.Padding(4);
            this.lsvClient.Name = "lsvClient";
            this.lsvClient.Size = new System.Drawing.Size(431, 546);
            this.lsvClient.TabIndex = 21;
            this.lsvClient.UseCompatibleStateImageBehavior = false;
            this.lsvClient.View = System.Windows.Forms.View.Details;
            this.lsvClient.SelectedIndexChanged += new System.EventHandler(this.lsvClient_SelectedIndexChanged_1);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 80;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 80;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 80;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(180, 382);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(180, 335);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.Color.White;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(180, 228);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(101, 25);
            this.lblForename.TabIndex = 18;
            this.lblForename.Text = "Forename";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.White;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(180, 188);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(86, 25);
            this.lblCustomerID.TabIndex = 17;
            this.lblCustomerID.Text = "Client ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(175, 91);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 58);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Client";
            // 
            // lblClientIDRead
            // 
            this.lblClientIDRead.AutoSize = true;
            this.lblClientIDRead.BackColor = System.Drawing.Color.White;
            this.lblClientIDRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientIDRead.Location = new System.Drawing.Point(434, 188);
            this.lblClientIDRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientIDRead.Name = "lblClientIDRead";
            this.lblClientIDRead.Size = new System.Drawing.Size(0, 25);
            this.lblClientIDRead.TabIndex = 49;
            // 
            // txbSurname
            // 
            this.txbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSurname.Location = new System.Drawing.Point(439, 278);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(179, 30);
            this.txbSurname.TabIndex = 51;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.White;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(180, 282);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 25);
            this.lblSurname.TabIndex = 50;
            this.lblSurname.Text = "Surname";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1285, 732);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblClientIDRead);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbForename);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lsvClient);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mstCustomer);
            this.MainMenuStrip = this.mstCustomer;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mstCustomer.ResumeLayout(false);
            this.mstCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstCustomer;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayCareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileGroomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbForename;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lsvClient;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientIDRead;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}
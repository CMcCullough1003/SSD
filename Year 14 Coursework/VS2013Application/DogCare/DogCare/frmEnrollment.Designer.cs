﻿namespace DogCare
{
    partial class frmEnrollment
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
            this.cbxDog = new System.Windows.Forms.ComboBox();
            this.lblDog = new System.Windows.Forms.Label();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblEnrollment = new System.Windows.Forms.Label();
            this.lsvEnrollment = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJoinDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInviteIssued = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxProgram = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameReadOnly = new System.Windows.Forms.Label();
            this.rbtnPayInFull = new System.Windows.Forms.RadioButton();
            this.rbtnPayByInstallments = new System.Windows.Forms.RadioButton();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblJoinDateReadOnly = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.gbxInviteIssued = new System.Windows.Forms.GroupBox();
            this.rbtnInviteIssuedNo = new System.Windows.Forms.RadioButton();
            this.rbtnInviteIssuedYes = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxInviteIssued.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDog
            // 
            this.cbxDog.FormattingEnabled = true;
            this.cbxDog.Location = new System.Drawing.Point(710, 246);
            this.cbxDog.Name = "cbxDog";
            this.cbxDog.Size = new System.Drawing.Size(245, 24);
            this.cbxDog.TabIndex = 88;
            this.cbxDog.Text = "Please select";
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDog.Location = new System.Drawing.Point(707, 226);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(37, 17);
            this.lblDog.TabIndex = 87;
            this.lblDog.Text = "Dog";
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(710, 190);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(245, 24);
            this.cbxClient.TabIndex = 86;
            this.cbxClient.Text = "Please select";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(707, 280);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(69, 17);
            this.lblProgram.TabIndex = 82;
            this.lblProgram.Text = "Program";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(707, 170);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 17);
            this.lblClient.TabIndex = 81;
            this.lblClient.Text = "Client";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(568, 82);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 80;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(705, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 17);
            this.lblID.TabIndex = 79;
            this.lblID.Text = "Enrollment ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(896, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(708, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(91, 526);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 76;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblEnrollment
            // 
            this.lblEnrollment.AutoSize = true;
            this.lblEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollment.Location = new System.Drawing.Point(86, 106);
            this.lblEnrollment.Name = "lblEnrollment";
            this.lblEnrollment.Size = new System.Drawing.Size(135, 29);
            this.lblEnrollment.TabIndex = 75;
            this.lblEnrollment.Text = "Enrollment";
            // 
            // lsvEnrollment
            // 
            this.lsvEnrollment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chClient,
            this.chDog,
            this.chProgram,
            this.chPaymentMethod,
            this.chJoinDate,
            this.chInviteIssued});
            this.lsvEnrollment.FullRowSelect = true;
            this.lsvEnrollment.GridLines = true;
            this.lsvEnrollment.Location = new System.Drawing.Point(91, 150);
            this.lsvEnrollment.Name = "lsvEnrollment";
            this.lsvEnrollment.Size = new System.Drawing.Size(580, 355);
            this.lsvEnrollment.TabIndex = 74;
            this.lsvEnrollment.UseCompatibleStateImageBehavior = false;
            this.lsvEnrollment.View = System.Windows.Forms.View.Details;
            this.lsvEnrollment.SelectedIndexChanged += new System.EventHandler(this.lsvEnrollment_SelectedIndexChanged_1);
            // 
            // chID
            // 
            this.chID.Text = "Enrollment ID";
            this.chID.Width = 80;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chClient
            // 
            this.chClient.Text = "Client";
            this.chClient.Width = 76;
            // 
            // chDog
            // 
            this.chDog.Text = "Dog";
            // 
            // chProgram
            // 
            this.chProgram.Text = "Program";
            // 
            // chPaymentMethod
            // 
            this.chPaymentMethod.Text = "Payment method";
            // 
            // chJoinDate
            // 
            this.chJoinDate.Text = "Join Date";
            // 
            // chInviteIssued
            // 
            this.chInviteIssued.Text = "Invite Issued";
            // 
            // cbxProgram
            // 
            this.cbxProgram.FormattingEnabled = true;
            this.cbxProgram.Location = new System.Drawing.Point(710, 300);
            this.cbxProgram.Name = "cbxProgram";
            this.cbxProgram.Size = new System.Drawing.Size(245, 24);
            this.cbxProgram.TabIndex = 89;
            this.cbxProgram.Text = "Please select";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(707, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 103;
            this.lblName.Text = "Name";
            // 
            // lblNameReadOnly
            // 
            this.lblNameReadOnly.AutoSize = true;
            this.lblNameReadOnly.Location = new System.Drawing.Point(715, 139);
            this.lblNameReadOnly.Name = "lblNameReadOnly";
            this.lblNameReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblNameReadOnly.TabIndex = 104;
            // 
            // rbtnPayInFull
            // 
            this.rbtnPayInFull.AutoSize = true;
            this.rbtnPayInFull.Location = new System.Drawing.Point(710, 360);
            this.rbtnPayInFull.Name = "rbtnPayInFull";
            this.rbtnPayInFull.Size = new System.Drawing.Size(90, 21);
            this.rbtnPayInFull.TabIndex = 105;
            this.rbtnPayInFull.TabStop = true;
            this.rbtnPayInFull.Text = "Pay in full";
            this.rbtnPayInFull.UseVisualStyleBackColor = true;
            // 
            // rbtnPayByInstallments
            // 
            this.rbtnPayByInstallments.AutoSize = true;
            this.rbtnPayByInstallments.Location = new System.Drawing.Point(815, 360);
            this.rbtnPayByInstallments.Name = "rbtnPayByInstallments";
            this.rbtnPayByInstallments.Size = new System.Drawing.Size(150, 21);
            this.rbtnPayByInstallments.TabIndex = 106;
            this.rbtnPayByInstallments.TabStop = true;
            this.rbtnPayByInstallments.Text = "Pay by installments";
            this.rbtnPayByInstallments.UseVisualStyleBackColor = true;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(707, 340);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(128, 17);
            this.lblPaymentMethod.TabIndex = 107;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // lblJoinDateReadOnly
            // 
            this.lblJoinDateReadOnly.AutoSize = true;
            this.lblJoinDateReadOnly.Location = new System.Drawing.Point(718, 424);
            this.lblJoinDateReadOnly.Name = "lblJoinDateReadOnly";
            this.lblJoinDateReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblJoinDateReadOnly.TabIndex = 109;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(712, 398);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(72, 17);
            this.lblJoinDate.TabIndex = 108;
            this.lblJoinDate.Text = "JoinDate";
            // 
            // gbxInviteIssued
            // 
            this.gbxInviteIssued.Controls.Add(this.rbtnInviteIssuedNo);
            this.gbxInviteIssued.Controls.Add(this.rbtnInviteIssuedYes);
            this.gbxInviteIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInviteIssued.Location = new System.Drawing.Point(708, 450);
            this.gbxInviteIssued.Name = "gbxInviteIssued";
            this.gbxInviteIssued.Size = new System.Drawing.Size(155, 55);
            this.gbxInviteIssued.TabIndex = 110;
            this.gbxInviteIssued.TabStop = false;
            this.gbxInviteIssued.Text = "InviteIssued";
            // 
            // rbtnInviteIssuedNo
            // 
            this.rbtnInviteIssuedNo.AutoSize = true;
            this.rbtnInviteIssuedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInviteIssuedNo.Location = new System.Drawing.Point(87, 23);
            this.rbtnInviteIssuedNo.Name = "rbtnInviteIssuedNo";
            this.rbtnInviteIssuedNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnInviteIssuedNo.TabIndex = 108;
            this.rbtnInviteIssuedNo.TabStop = true;
            this.rbtnInviteIssuedNo.Text = "No";
            this.rbtnInviteIssuedNo.UseVisualStyleBackColor = true;
            // 
            // rbtnInviteIssuedYes
            // 
            this.rbtnInviteIssuedYes.AutoSize = true;
            this.rbtnInviteIssuedYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInviteIssuedYes.Location = new System.Drawing.Point(16, 23);
            this.rbtnInviteIssuedYes.Name = "rbtnInviteIssuedYes";
            this.rbtnInviteIssuedYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnInviteIssuedYes.TabIndex = 107;
            this.rbtnInviteIssuedYes.TabStop = true;
            this.rbtnInviteIssuedYes.Text = "Yes";
            this.rbtnInviteIssuedYes.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(930, 46);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 29);
            this.btnBack.TabIndex = 111;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxInviteIssued);
            this.Controls.Add(this.lblJoinDateReadOnly);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.rbtnPayByInstallments);
            this.Controls.Add(this.rbtnPayInFull);
            this.Controls.Add(this.lblNameReadOnly);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxProgram);
            this.Controls.Add(this.cbxDog);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblIDReadOnly);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblEnrollment);
            this.Controls.Add(this.lsvEnrollment);
            this.Name = "frmEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnrollment";
            this.gbxInviteIssued.ResumeLayout(false);
            this.gbxInviteIssued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDog;
        private System.Windows.Forms.Label lblDog;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblEnrollment;
        private System.Windows.Forms.ListView lsvEnrollment;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chClient;
        private System.Windows.Forms.ColumnHeader chDog;
        private System.Windows.Forms.ColumnHeader chProgram;
        private System.Windows.Forms.ComboBox cbxProgram;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameReadOnly;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.RadioButton rbtnPayInFull;
        private System.Windows.Forms.RadioButton rbtnPayByInstallments;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ColumnHeader chPaymentMethod;
        private System.Windows.Forms.Label lblJoinDateReadOnly;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.GroupBox gbxInviteIssued;
        private System.Windows.Forms.RadioButton rbtnInviteIssuedNo;
        private System.Windows.Forms.RadioButton rbtnInviteIssuedYes;
        private System.Windows.Forms.ColumnHeader chJoinDate;
        private System.Windows.Forms.ColumnHeader chInviteIssued;
        private System.Windows.Forms.Button btnBack;
    }
}
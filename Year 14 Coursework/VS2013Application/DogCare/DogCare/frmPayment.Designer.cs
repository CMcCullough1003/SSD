namespace DogCare
{
    partial class frmPayment
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
            this.cbxEnrollment = new System.Windows.Forms.ComboBox();
            this.lblEnrollment = new System.Windows.Forms.Label();
            this.lblIDReadOnly = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lsvPayment = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnrollment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentRecieved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentRecievedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecieptIssued = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPaymentDue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblPaymentRecieved = new System.Windows.Forms.Label();
            this.lblPaymentRecievedDate = new System.Windows.Forms.Label();
            this.txtPaymentRecievedDate = new System.Windows.Forms.TextBox();
            this.rbtnPaymentRecievedNo = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentRecievedYes = new System.Windows.Forms.RadioButton();
            this.gbxRecieptIssued = new System.Windows.Forms.GroupBox();
            this.rbtnRecieptIssuedNo = new System.Windows.Forms.RadioButton();
            this.rbtnRecieptIssuedYes = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxRecieptIssued.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEnrollment
            // 
            this.cbxEnrollment.FormattingEnabled = true;
            this.cbxEnrollment.Location = new System.Drawing.Point(524, 195);
            this.cbxEnrollment.Name = "cbxEnrollment";
            this.cbxEnrollment.Size = new System.Drawing.Size(164, 24);
            this.cbxEnrollment.TabIndex = 99;
            this.cbxEnrollment.Text = "Please select";
            // 
            // lblEnrollment
            // 
            this.lblEnrollment.AutoSize = true;
            this.lblEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollment.Location = new System.Drawing.Point(521, 175);
            this.lblEnrollment.Name = "lblEnrollment";
            this.lblEnrollment.Size = new System.Drawing.Size(85, 17);
            this.lblEnrollment.TabIndex = 97;
            this.lblEnrollment.Text = "Enrollment";
            // 
            // lblIDReadOnly
            // 
            this.lblIDReadOnly.AutoSize = true;
            this.lblIDReadOnly.Location = new System.Drawing.Point(521, 151);
            this.lblIDReadOnly.Name = "lblIDReadOnly";
            this.lblIDReadOnly.Size = new System.Drawing.Size(0, 17);
            this.lblIDReadOnly.TabIndex = 96;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(521, 125);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 17);
            this.lblID.TabIndex = 95;
            this.lblID.Text = "Payment ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 29);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(46, 501);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 92;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(41, 81);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(114, 29);
            this.lblPayment.TabIndex = 91;
            this.lblPayment.Text = "Payment";
            // 
            // lsvPayment
            // 
            this.lsvPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chEnrollment,
            this.chPayment,
            this.chDueDate,
            this.chPaymentRecieved,
            this.chPaymentRecievedDate,
            this.chRecieptIssued});
            this.lsvPayment.FullRowSelect = true;
            this.lsvPayment.GridLines = true;
            this.lsvPayment.Location = new System.Drawing.Point(46, 125);
            this.lsvPayment.Name = "lsvPayment";
            this.lsvPayment.Size = new System.Drawing.Size(424, 355);
            this.lsvPayment.TabIndex = 90;
            this.lsvPayment.UseCompatibleStateImageBehavior = false;
            this.lsvPayment.View = System.Windows.Forms.View.Details;
            this.lsvPayment.SelectedIndexChanged += new System.EventHandler(this.lsvPayment_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "Class ID";
            this.chID.Width = 80;
            // 
            // chEnrollment
            // 
            this.chEnrollment.Text = "Enrollment";
            this.chEnrollment.Width = 76;
            // 
            // chPayment
            // 
            this.chPayment.Text = "Payment";
            // 
            // chDueDate
            // 
            this.chDueDate.Text = "Due date";
            // 
            // chPaymentRecieved
            // 
            this.chPaymentRecieved.Text = "Payment recieved";
            // 
            // chPaymentRecievedDate
            // 
            this.chPaymentRecievedDate.Text = "Payment recieved date";
            // 
            // chRecieptIssued
            // 
            this.chRecieptIssued.Text = "RecieptIssued";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(524, 256);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(164, 22);
            this.txtPayment.TabIndex = 100;
            // 
            // lblPaymentDue
            // 
            this.lblPaymentDue.AutoSize = true;
            this.lblPaymentDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDue.Location = new System.Drawing.Point(521, 236);
            this.lblPaymentDue.Name = "lblPaymentDue";
            this.lblPaymentDue.Size = new System.Drawing.Size(70, 17);
            this.lblPaymentDue.TabIndex = 101;
            this.lblPaymentDue.Text = "Payment";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(521, 287);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(74, 17);
            this.lblDueDate.TabIndex = 103;
            this.lblDueDate.Text = "Due date";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(524, 307);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(164, 22);
            this.txtDueDate.TabIndex = 102;
            // 
            // lblPaymentRecieved
            // 
            this.lblPaymentRecieved.AutoSize = true;
            this.lblPaymentRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRecieved.Location = new System.Drawing.Point(521, 340);
            this.lblPaymentRecieved.Name = "lblPaymentRecieved";
            this.lblPaymentRecieved.Size = new System.Drawing.Size(137, 17);
            this.lblPaymentRecieved.TabIndex = 105;
            this.lblPaymentRecieved.Text = "Payment recieved";
            // 
            // lblPaymentRecievedDate
            // 
            this.lblPaymentRecievedDate.AutoSize = true;
            this.lblPaymentRecievedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRecievedDate.Location = new System.Drawing.Point(521, 391);
            this.lblPaymentRecievedDate.Name = "lblPaymentRecievedDate";
            this.lblPaymentRecievedDate.Size = new System.Drawing.Size(174, 17);
            this.lblPaymentRecievedDate.TabIndex = 107;
            this.lblPaymentRecievedDate.Text = "Payment recieved date";
            // 
            // txtPaymentRecievedDate
            // 
            this.txtPaymentRecievedDate.Location = new System.Drawing.Point(524, 411);
            this.txtPaymentRecievedDate.Name = "txtPaymentRecievedDate";
            this.txtPaymentRecievedDate.Size = new System.Drawing.Size(164, 22);
            this.txtPaymentRecievedDate.TabIndex = 106;
            // 
            // rbtnPaymentRecievedNo
            // 
            this.rbtnPaymentRecievedNo.AutoSize = true;
            this.rbtnPaymentRecievedNo.Location = new System.Drawing.Point(594, 360);
            this.rbtnPaymentRecievedNo.Name = "rbtnPaymentRecievedNo";
            this.rbtnPaymentRecievedNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnPaymentRecievedNo.TabIndex = 111;
            this.rbtnPaymentRecievedNo.TabStop = true;
            this.rbtnPaymentRecievedNo.Text = "No";
            this.rbtnPaymentRecievedNo.UseVisualStyleBackColor = true;
            // 
            // rbtnPaymentRecievedYes
            // 
            this.rbtnPaymentRecievedYes.AutoSize = true;
            this.rbtnPaymentRecievedYes.Location = new System.Drawing.Point(524, 360);
            this.rbtnPaymentRecievedYes.Name = "rbtnPaymentRecievedYes";
            this.rbtnPaymentRecievedYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnPaymentRecievedYes.TabIndex = 110;
            this.rbtnPaymentRecievedYes.TabStop = true;
            this.rbtnPaymentRecievedYes.Text = "Yes";
            this.rbtnPaymentRecievedYes.UseVisualStyleBackColor = true;
            // 
            // gbxRecieptIssued
            // 
            this.gbxRecieptIssued.BackColor = System.Drawing.Color.Transparent;
            this.gbxRecieptIssued.Controls.Add(this.rbtnRecieptIssuedNo);
            this.gbxRecieptIssued.Controls.Add(this.rbtnRecieptIssuedYes);
            this.gbxRecieptIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRecieptIssued.Location = new System.Drawing.Point(514, 437);
            this.gbxRecieptIssued.Name = "gbxRecieptIssued";
            this.gbxRecieptIssued.Size = new System.Drawing.Size(200, 58);
            this.gbxRecieptIssued.TabIndex = 114;
            this.gbxRecieptIssued.TabStop = false;
            this.gbxRecieptIssued.Text = "Reciept issued";
            // 
            // rbtnRecieptIssuedNo
            // 
            this.rbtnRecieptIssuedNo.AutoSize = true;
            this.rbtnRecieptIssuedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRecieptIssuedNo.Location = new System.Drawing.Point(85, 22);
            this.rbtnRecieptIssuedNo.Name = "rbtnRecieptIssuedNo";
            this.rbtnRecieptIssuedNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnRecieptIssuedNo.TabIndex = 115;
            this.rbtnRecieptIssuedNo.TabStop = true;
            this.rbtnRecieptIssuedNo.Text = "No";
            this.rbtnRecieptIssuedNo.UseVisualStyleBackColor = true;
            // 
            // rbtnRecieptIssuedYes
            // 
            this.rbtnRecieptIssuedYes.AutoSize = true;
            this.rbtnRecieptIssuedYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRecieptIssuedYes.Location = new System.Drawing.Point(15, 22);
            this.rbtnRecieptIssuedYes.Name = "rbtnRecieptIssuedYes";
            this.rbtnRecieptIssuedYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnRecieptIssuedYes.TabIndex = 114;
            this.rbtnRecieptIssuedYes.TabStop = true;
            this.rbtnRecieptIssuedYes.Text = "Yes";
            this.rbtnRecieptIssuedYes.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(712, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 116;
            this.comboBox1.Text = "Please select";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(709, 175);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(106, 17);
            this.lblPaymentType.TabIndex = 115;
            this.lblPaymentType.Text = "Payment type";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(712, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 29);
            this.btnBack.TabIndex = 117;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 610);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.rbtnPaymentRecievedNo);
            this.Controls.Add(this.rbtnPaymentRecievedYes);
            this.Controls.Add(this.lblPaymentRecievedDate);
            this.Controls.Add(this.txtPaymentRecievedDate);
            this.Controls.Add(this.lblPaymentRecieved);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.lblPaymentDue);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.cbxEnrollment);
            this.Controls.Add(this.lblEnrollment);
            this.Controls.Add(this.lblIDReadOnly);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lsvPayment);
            this.Controls.Add(this.gbxRecieptIssued);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.gbxRecieptIssued.ResumeLayout(false);
            this.gbxRecieptIssued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEnrollment;
        private System.Windows.Forms.Label lblEnrollment;
        private System.Windows.Forms.Label lblIDReadOnly;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ListView lsvPayment;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chEnrollment;
        private System.Windows.Forms.ColumnHeader chPayment;
        private System.Windows.Forms.ColumnHeader chDueDate;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPaymentDue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblPaymentRecieved;
        private System.Windows.Forms.Label lblPaymentRecievedDate;
        private System.Windows.Forms.TextBox txtPaymentRecievedDate;
        private System.Windows.Forms.RadioButton rbtnPaymentRecievedNo;
        private System.Windows.Forms.RadioButton rbtnPaymentRecievedYes;
        private System.Windows.Forms.ColumnHeader chPaymentRecieved;
        private System.Windows.Forms.ColumnHeader chPaymentRecievedDate;
        private System.Windows.Forms.ColumnHeader chRecieptIssued;
        private System.Windows.Forms.GroupBox gbxRecieptIssued;
        private System.Windows.Forms.RadioButton rbtnRecieptIssuedNo;
        private System.Windows.Forms.RadioButton rbtnRecieptIssuedYes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnBack;
    }
}
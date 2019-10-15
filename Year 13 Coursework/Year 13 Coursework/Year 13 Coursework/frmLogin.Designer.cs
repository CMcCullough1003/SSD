﻿namespace Year_13_Coursework
{
    partial class frmLogin
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblClickToJoin = new System.Windows.Forms.Label();
            this.btnExitQuiz = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pbxGlobe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGlobe)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(324, 288);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(357, 53);
            this.tbxUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(411, 460);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 69);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(324, 378);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(357, 53);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(59, 288);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(208, 51);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(59, 383);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 51);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(432, 614);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 49);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.Location = new System.Drawing.Point(379, 551);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(273, 27);
            this.lblCreateAccount.TabIndex = 7;
            this.lblCreateAccount.Text = "Don\'t have an account yet?";
            // 
            // lblClickToJoin
            // 
            this.lblClickToJoin.AutoSize = true;
            this.lblClickToJoin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToJoin.Location = new System.Drawing.Point(421, 585);
            this.lblClickToJoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickToJoin.Name = "lblClickToJoin";
            this.lblClickToJoin.Size = new System.Drawing.Size(178, 27);
            this.lblClickToJoin.TabIndex = 8;
            this.lblClickToJoin.Text = "Click here to join";
            // 
            // btnExitQuiz
            // 
            this.btnExitQuiz.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnExitQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitQuiz.ForeColor = System.Drawing.Color.White;
            this.btnExitQuiz.Location = new System.Drawing.Point(16, 599);
            this.btnExitQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitQuiz.Name = "btnExitQuiz";
            this.btnExitQuiz.Size = new System.Drawing.Size(207, 69);
            this.btnExitQuiz.TabIndex = 9;
            this.btnExitQuiz.Text = "Exit";
            this.btnExitQuiz.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(279, 124);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 135);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(295, 229);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(347, 36);
            this.lblSubtitle.TabIndex = 13;
            this.lblSubtitle.Text = "A Quiz about the Globe";
            // 
            // pbxGlobe
            // 
            this.pbxGlobe.Image = global::Year_13_Coursework.Properties.Resources.hiclipart_com_id_gnwvp;
            this.pbxGlobe.Location = new System.Drawing.Point(16, 22);
            this.pbxGlobe.Margin = new System.Windows.Forms.Padding(4);
            this.pbxGlobe.Name = "pbxGlobe";
            this.pbxGlobe.Size = new System.Drawing.Size(268, 239);
            this.pbxGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGlobe.TabIndex = 14;
            this.pbxGlobe.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 686);
            this.Controls.Add(this.pbxGlobe);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExitQuiz);
            this.Controls.Add(this.lblClickToJoin);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGlobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblClickToJoin;
        private System.Windows.Forms.Button btnExitQuiz;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox pbxGlobe;
    }
}
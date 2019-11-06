namespace Year_13_Coursework
{
    partial class frmGameMenu
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.btnResumeGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(16, 27);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(100, 46);
            this.lblGameTitle.TabIndex = 13;
            this.lblGameTitle.Text = "Title";
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblGameNumber.Location = new System.Drawing.Point(22, 90);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(115, 32);
            this.lblGameNumber.TabIndex = 12;
            this.lblGameNumber.Text = "Game 1";
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblGameInfo.Location = new System.Drawing.Point(20, 161);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(90, 20);
            this.lblGameInfo.TabIndex = 11;
            this.lblGameInfo.Text = "Information";
            // 
            // btnResumeGame
            // 
            this.btnResumeGame.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnResumeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeGame.ForeColor = System.Drawing.Color.White;
            this.btnResumeGame.Location = new System.Drawing.Point(746, 664);
            this.btnResumeGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResumeGame.Name = "btnResumeGame";
            this.btnResumeGame.Size = new System.Drawing.Size(174, 59);
            this.btnResumeGame.TabIndex = 10;
            this.btnResumeGame.Text = "Resume";
            this.btnResumeGame.UseVisualStyleBackColor = false;
            this.btnResumeGame.Click += new System.EventHandler(this.BtnResumeGame_Click);
            // 
            // frmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 737);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.lblGameNumber);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnResumeGame);
            this.Name = "frmGameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameMenu";
            this.Load += new System.EventHandler(this.FrmGameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Button btnResumeGame;
    }
}
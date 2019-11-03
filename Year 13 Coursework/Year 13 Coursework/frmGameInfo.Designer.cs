namespace Year_13_Coursework
{
    partial class frmGameInfo
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(425, 449);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(174, 59);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblGameInfo.Location = new System.Drawing.Point(16, 168);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(90, 20);
            this.lblGameInfo.TabIndex = 7;
            this.lblGameInfo.Text = "Information";
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblGameNumber.Location = new System.Drawing.Point(18, 97);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(115, 32);
            this.lblGameNumber.TabIndex = 8;
            this.lblGameNumber.Text = "Game 1";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(12, 34);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(100, 46);
            this.lblGameTitle.TabIndex = 9;
            this.lblGameTitle.Text = "Title";
            // 
            // frmGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 522);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.lblGameNumber);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnStartGame);
            this.Name = "frmGameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Information";
            this.Load += new System.EventHandler(this.FrmGame1Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label lblGameTitle;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameInfo));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblGamePoints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(513, 675);
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
            this.lblGameInfo.Location = new System.Drawing.Point(20, 482);
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
            this.lblGameNumber.Location = new System.Drawing.Point(18, 413);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(115, 32);
            this.lblGameNumber.TabIndex = 8;
            this.lblGameNumber.Text = "Game 1";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(16, 343);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(100, 46);
            this.lblGameTitle.TabIndex = 9;
            this.lblGameTitle.Text = "Title";
            // 
            // lblGamePoints
            // 
            this.lblGamePoints.AutoSize = true;
            this.lblGamePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePoints.ForeColor = System.Drawing.Color.DimGray;
            this.lblGamePoints.Location = new System.Drawing.Point(18, 688);
            this.lblGamePoints.Name = "lblGamePoints";
            this.lblGamePoints.Size = new System.Drawing.Size(95, 32);
            this.lblGamePoints.TabIndex = 10;
            this.lblGamePoints.Text = "Points";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Year_13_Coursework.Properties.Resources.Landmarks;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 766);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 748);
            this.Controls.Add(this.lblGamePoints);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.lblGameNumber);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Information";
            this.Load += new System.EventHandler(this.FrmGame1Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblGamePoints;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
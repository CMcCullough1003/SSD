namespace Year_13_Coursework
{
    partial class frmStartScreen
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
            this.lsvLeaderboards = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvLeaderboards
            // 
            this.lsvLeaderboards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Score});
            this.lsvLeaderboards.Location = new System.Drawing.Point(219, 245);
            this.lsvLeaderboards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvLeaderboards.Name = "lsvLeaderboards";
            this.lsvLeaderboards.Size = new System.Drawing.Size(239, 286);
            this.lsvLeaderboards.TabIndex = 3;
            this.lsvLeaderboards.UseCompatibleStateImageBehavior = false;
            this.lsvLeaderboards.View = System.Windows.Forms.View.Details;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 179;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 175;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(340, 534);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(116, 38);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Begin";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.Location = new System.Drawing.Point(219, 533);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(116, 40);
            this.btnBackToLogin.TabIndex = 2;
            this.btnBackToLogin.Text = "Back";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 583);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lsvLeaderboards);
            this.Name = "frmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvLeaderboards;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Score;
    }
}
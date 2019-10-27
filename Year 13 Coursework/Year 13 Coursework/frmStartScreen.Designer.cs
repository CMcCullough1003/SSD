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
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvLeaderboards
            // 
            this.lsvLeaderboards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Score});
            this.lsvLeaderboards.Location = new System.Drawing.Point(328, 377);
            this.lsvLeaderboards.Name = "lsvLeaderboards";
            this.lsvLeaderboards.Size = new System.Drawing.Size(356, 438);
            this.lsvLeaderboards.TabIndex = 0;
            this.lsvLeaderboards.UseCompatibleStateImageBehavior = false;
            this.lsvLeaderboards.View = System.Windows.Forms.View.Details;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(510, 822);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(174, 59);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Begin";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.Location = new System.Drawing.Point(328, 820);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(174, 61);
            this.btnBackToLogin.TabIndex = 7;
            this.btnBackToLogin.Text = "Back";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
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
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 897);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lsvLeaderboards);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
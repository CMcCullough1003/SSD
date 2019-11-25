namespace Year_13_Coursework
{
    partial class frmGame1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame1));
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.btnSkipGame = new System.Windows.Forms.Button();
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxCountry = new System.Windows.Forms.PictureBox();
            this.pbxHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(477, 423);
            this.btnAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(213, 35);
            this.btnAnswer2.TabIndex = 4;
            this.btnAnswer2.Text = "Answer";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.BtnAnswer2_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(256, 385);
            this.btnAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(213, 35);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Answer";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.BtnAnswer1_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.Location = new System.Drawing.Point(256, 423);
            this.btnAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(213, 35);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Answer";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.BtnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.Location = new System.Drawing.Point(477, 385);
            this.btnAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(213, 35);
            this.btnAnswer4.TabIndex = 2;
            this.btnAnswer4.Text = "Answer";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.BtnAnswer4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(697, 385);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(61, 35);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(695, 119);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 178;
            this.lblTimer.Text = "Timer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(695, 160);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 177;
            this.lblScore.Text = "Score";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(251, 87);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 31);
            this.lblTitle.TabIndex = 176;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.BackColor = System.Drawing.Color.White;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreCount.Location = new System.Drawing.Point(695, 173);
            this.lblScoreCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(20, 24);
            this.lblScoreCount.TabIndex = 175;
            this.lblScoreCount.Text = "0";
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BackColor = System.Drawing.Color.White;
            this.lblTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimerCount.Location = new System.Drawing.Point(695, 132);
            this.lblTimerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(30, 24);
            this.lblTimerCount.TabIndex = 174;
            this.lblTimerCount.Text = "10";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSkipGame
            // 
            this.btnSkipGame.Location = new System.Drawing.Point(697, 423);
            this.btnSkipGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkipGame.Name = "btnSkipGame";
            this.btnSkipGame.Size = new System.Drawing.Size(61, 35);
            this.btnSkipGame.TabIndex = 6;
            this.btnSkipGame.Text = "Skip";
            this.btnSkipGame.UseVisualStyleBackColor = true;
            this.btnSkipGame.Click += new System.EventHandler(this.BtnSkipGame_Click);
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark21;
            this.pbxThought.Location = new System.Drawing.Point(697, 262);
            this.pbxThought.Margin = new System.Windows.Forms.Padding(2);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(61, 58);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 14;
            this.pbxThought.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(698, 324);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(61, 58);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxCountry
            // 
            this.pbxCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCountry.Location = new System.Drawing.Point(256, 119);
            this.pbxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCountry.Name = "pbxCountry";
            this.pbxCountry.Size = new System.Drawing.Size(435, 263);
            this.pbxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCountry.TabIndex = 0;
            this.pbxCountry.TabStop = false;
            // 
            // pbxHeader
            // 
            this.pbxHeader.BackColor = System.Drawing.Color.White;
            this.pbxHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxHeader.Location = new System.Drawing.Point(235, 74);
            this.pbxHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pbxHeader.Name = "pbxHeader";
            this.pbxHeader.Size = new System.Drawing.Size(539, 410);
            this.pbxHeader.TabIndex = 179;
            this.pbxHeader.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Year_13_Coursework.Properties.Resources.BackgroundRoad;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 558);
            this.Controls.Add(this.btnSkipGame);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.pbxCountry);
            this.Controls.Add(this.pbxHeader);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 1";
            this.Activated += new System.EventHandler(this.FrmGame1_Activated);
            this.Load += new System.EventHandler(this.FrmGame1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCountry;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxThought;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.PictureBox pbxHeader;
        private System.Windows.Forms.Button btnSkipGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
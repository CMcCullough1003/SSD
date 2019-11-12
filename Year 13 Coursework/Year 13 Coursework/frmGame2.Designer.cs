namespace Year_13_Coursework
{
    partial class frmGame2
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.tbxGuess = new System.Windows.Forms.TextBox();
            this.btnNextClue = new System.Windows.Forms.Button();
            this.lblHint1Title = new System.Windows.Forms.Label();
            this.lblHint3Title = new System.Windows.Forms.Label();
            this.lblHint2Title = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.lblHint3 = new System.Windows.Forms.Label();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxClue3 = new System.Windows.Forms.PictureBox();
            this.pbxClue2 = new System.Windows.Forms.PictureBox();
            this.pbxClue1 = new System.Windows.Forms.PictureBox();
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxBubble3 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.pbxHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(18, 665);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(225, 46);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.ForeColor = System.Drawing.Color.White;
            this.btnSubmitAnswer.Location = new System.Drawing.Point(599, 651);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(320, 60);
            this.btnSubmitAnswer.TabIndex = 22;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.BtnSubmitAnswer_Click);
            // 
            // tbxGuess
            // 
            this.tbxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuess.Location = new System.Drawing.Point(283, 654);
            this.tbxGuess.Name = "tbxGuess";
            this.tbxGuess.Size = new System.Drawing.Size(310, 53);
            this.tbxGuess.TabIndex = 32;
            // 
            // btnNextClue
            // 
            this.btnNextClue.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnNextClue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextClue.ForeColor = System.Drawing.Color.White;
            this.btnNextClue.Location = new System.Drawing.Point(405, 470);
            this.btnNextClue.Name = "btnNextClue";
            this.btnNextClue.Size = new System.Drawing.Size(320, 60);
            this.btnNextClue.TabIndex = 33;
            this.btnNextClue.Text = "Next clue";
            this.btnNextClue.UseVisualStyleBackColor = false;
            this.btnNextClue.Click += new System.EventHandler(this.BtnNextClue_Click);
            // 
            // lblHint1Title
            // 
            this.lblHint1Title.AutoSize = true;
            this.lblHint1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint1Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint1Title.Location = new System.Drawing.Point(316, 178);
            this.lblHint1Title.Name = "lblHint1Title";
            this.lblHint1Title.Size = new System.Drawing.Size(97, 32);
            this.lblHint1Title.TabIndex = 34;
            this.lblHint1Title.Text = "Clue 1";
            // 
            // lblHint3Title
            // 
            this.lblHint3Title.AutoSize = true;
            this.lblHint3Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint3Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint3Title.Location = new System.Drawing.Point(750, 178);
            this.lblHint3Title.Name = "lblHint3Title";
            this.lblHint3Title.Size = new System.Drawing.Size(97, 32);
            this.lblHint3Title.TabIndex = 36;
            this.lblHint3Title.Text = "Clue 3";
            // 
            // lblHint2Title
            // 
            this.lblHint2Title.AutoSize = true;
            this.lblHint2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint2Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint2Title.Location = new System.Drawing.Point(525, 178);
            this.lblHint2Title.Name = "lblHint2Title";
            this.lblHint2Title.Size = new System.Drawing.Size(97, 32);
            this.lblHint2Title.TabIndex = 37;
            this.lblHint2Title.Text = "Clue 2";
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint2.ForeColor = System.Drawing.Color.Gray;
            this.lblHint2.Location = new System.Drawing.Point(495, 423);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(54, 20);
            this.lblHint2.TabIndex = 43;
            this.lblHint2.Text = "Clue 2";
            // 
            // lblHint3
            // 
            this.lblHint3.AutoSize = true;
            this.lblHint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint3.ForeColor = System.Drawing.Color.Gray;
            this.lblHint3.Location = new System.Drawing.Point(720, 423);
            this.lblHint3.Name = "lblHint3";
            this.lblHint3.Size = new System.Drawing.Size(54, 20);
            this.lblHint3.TabIndex = 42;
            this.lblHint3.Text = "Clue 3";
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint1.ForeColor = System.Drawing.Color.Gray;
            this.lblHint1.Location = new System.Drawing.Point(279, 423);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(54, 20);
            this.lblHint1.TabIndex = 41;
            this.lblHint1.Text = "Clue 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(287, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Enter your guess:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pbxClue3
            // 
            this.pbxClue3.Image = global::Year_13_Coursework.Properties.Resources.questionMark11;
            this.pbxClue3.Location = new System.Drawing.Point(714, 240);
            this.pbxClue3.Name = "pbxClue3";
            this.pbxClue3.Size = new System.Drawing.Size(160, 160);
            this.pbxClue3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClue3.TabIndex = 40;
            this.pbxClue3.TabStop = false;
            // 
            // pbxClue2
            // 
            this.pbxClue2.Image = global::Year_13_Coursework.Properties.Resources.questionMark11;
            this.pbxClue2.Location = new System.Drawing.Point(489, 240);
            this.pbxClue2.Name = "pbxClue2";
            this.pbxClue2.Size = new System.Drawing.Size(160, 160);
            this.pbxClue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClue2.TabIndex = 39;
            this.pbxClue2.TabStop = false;
            // 
            // pbxClue1
            // 
            this.pbxClue1.Image = global::Year_13_Coursework.Properties.Resources.questionMark11;
            this.pbxClue1.Location = new System.Drawing.Point(283, 240);
            this.pbxClue1.Name = "pbxClue1";
            this.pbxClue1.Size = new System.Drawing.Size(160, 160);
            this.pbxClue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClue1.TabIndex = 38;
            this.pbxClue1.TabStop = false;
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark21;
            this.pbxThought.Location = new System.Drawing.Point(76, 185);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(118, 112);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 28;
            this.pbxThought.TabStop = false;
            // 
            // pbxBubble3
            // 
            this.pbxBubble3.Image = global::Year_13_Coursework.Properties.Resources.thoughtBubble3;
            this.pbxBubble3.Location = new System.Drawing.Point(18, 114);
            this.pbxBubble3.Name = "pbxBubble3";
            this.pbxBubble3.Size = new System.Drawing.Size(225, 336);
            this.pbxBubble3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBubble3.TabIndex = 24;
            this.pbxBubble3.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(18, 456);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(225, 203);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 23;
            this.pbxAvatar.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(867, 23);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(48, 20);
            this.lblTimer.TabIndex = 178;
            this.lblTimer.Text = "Timer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(14, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 177;
            this.lblScore.Text = "Score";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(253, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 46);
            this.lblTitle.TabIndex = 176;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreCount.Location = new System.Drawing.Point(23, 53);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(31, 32);
            this.lblScoreCount.TabIndex = 175;
            this.lblScoreCount.Text = "0";
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimerCount.Location = new System.Drawing.Point(873, 53);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(47, 32);
            this.lblTimerCount.TabIndex = 174;
            this.lblTimerCount.Text = "10";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxHeader
            // 
            this.pbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbxHeader.Location = new System.Drawing.Point(0, 0);
            this.pbxHeader.Name = "pbxHeader";
            this.pbxHeader.Size = new System.Drawing.Size(934, 106);
            this.pbxHeader.TabIndex = 179;
            this.pbxHeader.TabStop = false;
            // 
            // frmGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 737);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.pbxHeader);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblHint3);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.pbxClue3);
            this.Controls.Add(this.pbxClue2);
            this.Controls.Add(this.pbxClue1);
            this.Controls.Add(this.lblHint2Title);
            this.Controls.Add(this.lblHint3Title);
            this.Controls.Add(this.lblHint1Title);
            this.Controls.Add(this.btnNextClue);
            this.Controls.Add(this.tbxGuess);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.pbxBubble3);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Name = "frmGame2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 2";
            this.Activated += new System.EventHandler(this.FrmGame2_Activated);
            this.Load += new System.EventHandler(this.FrmGame2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbxThought;
        private System.Windows.Forms.PictureBox pbxBubble3;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.TextBox tbxGuess;
        private System.Windows.Forms.Button btnNextClue;
        private System.Windows.Forms.Label lblHint1Title;
        private System.Windows.Forms.Label lblHint3Title;
        private System.Windows.Forms.Label lblHint2Title;
        private System.Windows.Forms.PictureBox pbxClue1;
        private System.Windows.Forms.PictureBox pbxClue2;
        private System.Windows.Forms.PictureBox pbxClue3;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label lblHint3;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.PictureBox pbxHeader;
    }
}
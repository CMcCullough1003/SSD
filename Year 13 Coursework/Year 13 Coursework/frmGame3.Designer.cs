namespace Year_13_Coursework
{
    partial class frmGame3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGuess = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.pbxHide9 = new System.Windows.Forms.PictureBox();
            this.pbxHide8 = new System.Windows.Forms.PictureBox();
            this.pbxHide7 = new System.Windows.Forms.PictureBox();
            this.pbxHide6 = new System.Windows.Forms.PictureBox();
            this.pbxHide5 = new System.Windows.Forms.PictureBox();
            this.pbxHide4 = new System.Windows.Forms.PictureBox();
            this.pbxHide3 = new System.Windows.Forms.PictureBox();
            this.pbxHide2 = new System.Windows.Forms.PictureBox();
            this.pbxHide1 = new System.Windows.Forms.PictureBox();
            this.pbxFlag = new System.Windows.Forms.PictureBox();
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxBubble3 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.pbxHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(287, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Enter your guess:";
            // 
            // tbxGuess
            // 
            this.tbxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuess.Location = new System.Drawing.Point(283, 654);
            this.tbxGuess.Name = "tbxGuess";
            this.tbxGuess.Size = new System.Drawing.Size(310, 53);
            this.tbxGuess.TabIndex = 55;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(18, 665);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(225, 46);
            this.btnHelp.TabIndex = 54;
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
            this.btnSubmitAnswer.TabIndex = 45;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.BtnSubmitAnswer_Click);
            // 
            // pbxHide9
            // 
            this.pbxHide9.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide9.Image")));
            this.pbxHide9.Location = new System.Drawing.Point(704, 426);
            this.pbxHide9.Name = "pbxHide9";
            this.pbxHide9.Size = new System.Drawing.Size(210, 157);
            this.pbxHide9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide9.TabIndex = 76;
            this.pbxHide9.TabStop = false;
            this.pbxHide9.Click += new System.EventHandler(this.PbxHide9_Click);
            // 
            // pbxHide8
            // 
            this.pbxHide8.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide8.Image")));
            this.pbxHide8.Location = new System.Drawing.Point(493, 426);
            this.pbxHide8.Name = "pbxHide8";
            this.pbxHide8.Size = new System.Drawing.Size(210, 157);
            this.pbxHide8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide8.TabIndex = 75;
            this.pbxHide8.TabStop = false;
            this.pbxHide8.Click += new System.EventHandler(this.PbxHide8_Click);
            // 
            // pbxHide7
            // 
            this.pbxHide7.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide7.Image")));
            this.pbxHide7.Location = new System.Drawing.Point(283, 426);
            this.pbxHide7.Name = "pbxHide7";
            this.pbxHide7.Size = new System.Drawing.Size(210, 157);
            this.pbxHide7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide7.TabIndex = 74;
            this.pbxHide7.TabStop = false;
            this.pbxHide7.Click += new System.EventHandler(this.PbxHide7_Click);
            // 
            // pbxHide6
            // 
            this.pbxHide6.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide6.Image")));
            this.pbxHide6.Location = new System.Drawing.Point(704, 270);
            this.pbxHide6.Name = "pbxHide6";
            this.pbxHide6.Size = new System.Drawing.Size(210, 157);
            this.pbxHide6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide6.TabIndex = 73;
            this.pbxHide6.TabStop = false;
            this.pbxHide6.Click += new System.EventHandler(this.PbxHide6_Click);
            // 
            // pbxHide5
            // 
            this.pbxHide5.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide5.Image")));
            this.pbxHide5.Location = new System.Drawing.Point(493, 270);
            this.pbxHide5.Name = "pbxHide5";
            this.pbxHide5.Size = new System.Drawing.Size(210, 157);
            this.pbxHide5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide5.TabIndex = 72;
            this.pbxHide5.TabStop = false;
            this.pbxHide5.Click += new System.EventHandler(this.PbxHide5_Click);
            // 
            // pbxHide4
            // 
            this.pbxHide4.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide4.Image")));
            this.pbxHide4.Location = new System.Drawing.Point(283, 270);
            this.pbxHide4.Name = "pbxHide4";
            this.pbxHide4.Size = new System.Drawing.Size(210, 157);
            this.pbxHide4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide4.TabIndex = 71;
            this.pbxHide4.TabStop = false;
            this.pbxHide4.Click += new System.EventHandler(this.PbxHide4_Click);
            // 
            // pbxHide3
            // 
            this.pbxHide3.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide3.Image")));
            this.pbxHide3.Location = new System.Drawing.Point(704, 115);
            this.pbxHide3.Name = "pbxHide3";
            this.pbxHide3.Size = new System.Drawing.Size(210, 157);
            this.pbxHide3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide3.TabIndex = 70;
            this.pbxHide3.TabStop = false;
            this.pbxHide3.Click += new System.EventHandler(this.PbxHide3_Click);
            // 
            // pbxHide2
            // 
            this.pbxHide2.Image = ((System.Drawing.Image)(resources.GetObject("pbxHide2.Image")));
            this.pbxHide2.Location = new System.Drawing.Point(493, 115);
            this.pbxHide2.Name = "pbxHide2";
            this.pbxHide2.Size = new System.Drawing.Size(210, 157);
            this.pbxHide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide2.TabIndex = 69;
            this.pbxHide2.TabStop = false;
            this.pbxHide2.Click += new System.EventHandler(this.PbxHide2_Click);
            // 
            // pbxHide1
            // 
            this.pbxHide1.Image = global::Year_13_Coursework.Properties.Resources.redFlag;
            this.pbxHide1.Location = new System.Drawing.Point(283, 115);
            this.pbxHide1.Name = "pbxHide1";
            this.pbxHide1.Size = new System.Drawing.Size(210, 157);
            this.pbxHide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxHide1.TabIndex = 68;
            this.pbxHide1.TabStop = false;
            this.pbxHide1.Click += new System.EventHandler(this.PbxHide1_Click);
            // 
            // pbxFlag
            // 
            this.pbxFlag.Location = new System.Drawing.Point(283, 114);
            this.pbxFlag.Name = "pbxFlag";
            this.pbxFlag.Size = new System.Drawing.Size(631, 469);
            this.pbxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFlag.TabIndex = 67;
            this.pbxFlag.TabStop = false;
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark21;
            this.pbxThought.Location = new System.Drawing.Point(76, 185);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(118, 112);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 51;
            this.pbxThought.TabStop = false;
            // 
            // pbxBubble3
            // 
            this.pbxBubble3.Image = global::Year_13_Coursework.Properties.Resources.thoughtBubble3;
            this.pbxBubble3.Location = new System.Drawing.Point(18, 114);
            this.pbxBubble3.Name = "pbxBubble3";
            this.pbxBubble3.Size = new System.Drawing.Size(225, 336);
            this.pbxBubble3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBubble3.TabIndex = 47;
            this.pbxBubble3.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(18, 456);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(225, 203);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 46;
            this.pbxAvatar.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(867, 24);
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
            this.lblScore.Location = new System.Drawing.Point(14, 24);
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
            this.lblTitle.Location = new System.Drawing.Point(253, 43);
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
            this.lblScoreCount.Location = new System.Drawing.Point(23, 54);
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
            this.lblTimerCount.Location = new System.Drawing.Point(873, 54);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(47, 32);
            this.lblTimerCount.TabIndex = 174;
            this.lblTimerCount.Text = "10";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxHeader
            // 
            this.pbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbxHeader.Location = new System.Drawing.Point(0, 1);
            this.pbxHeader.Name = "pbxHeader";
            this.pbxHeader.Size = new System.Drawing.Size(934, 106);
            this.pbxHeader.TabIndex = 179;
            this.pbxHeader.TabStop = false;
            // 
            // frmGame3
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
            this.Controls.Add(this.pbxHide9);
            this.Controls.Add(this.pbxHide8);
            this.Controls.Add(this.pbxHide7);
            this.Controls.Add(this.pbxHide6);
            this.Controls.Add(this.pbxHide5);
            this.Controls.Add(this.pbxHide4);
            this.Controls.Add(this.pbxHide3);
            this.Controls.Add(this.pbxHide2);
            this.Controls.Add(this.pbxHide1);
            this.Controls.Add(this.pbxFlag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxGuess);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.pbxBubble3);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Name = "frmGame3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 3";
            this.Activated += new System.EventHandler(this.FrmGame3_Activated);
            this.Load += new System.EventHandler(this.FrmGame3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxGuess;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbxThought;
        private System.Windows.Forms.PictureBox pbxBubble3;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.PictureBox pbxFlag;
        private System.Windows.Forms.PictureBox pbxHide1;
        private System.Windows.Forms.PictureBox pbxHide2;
        private System.Windows.Forms.PictureBox pbxHide3;
        private System.Windows.Forms.PictureBox pbxHide6;
        private System.Windows.Forms.PictureBox pbxHide5;
        private System.Windows.Forms.PictureBox pbxHide4;
        private System.Windows.Forms.PictureBox pbxHide9;
        private System.Windows.Forms.PictureBox pbxHide8;
        private System.Windows.Forms.PictureBox pbxHide7;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.PictureBox pbxHeader;
    }
}
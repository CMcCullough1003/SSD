﻿namespace Year_13_Coursework
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
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxBubble3 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxCountry = new System.Windows.Forms.PictureBox();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(395, 354);
            this.btnAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(213, 55);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Answer";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.BtnAnswer2_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(175, 354);
            this.btnAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(213, 55);
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
            this.btnAnswer3.Location = new System.Drawing.Point(175, 416);
            this.btnAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(213, 55);
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
            this.btnAnswer4.Location = new System.Drawing.Point(395, 416);
            this.btnAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(213, 55);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Answer";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.BtnAnswer4_Click);
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimerCount.Location = new System.Drawing.Point(583, 45);
            this.lblTimerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(30, 24);
            this.lblTimerCount.TabIndex = 11;
            this.lblTimerCount.Text = "10";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreCount.Location = new System.Drawing.Point(16, 45);
            this.lblScoreCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(20, 24);
            this.lblScoreCount.TabIndex = 12;
            this.lblScoreCount.Text = "0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(169, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 31);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(10, 25);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(579, 25);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "Timer";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 441);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(150, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark21;
            this.pbxThought.Location = new System.Drawing.Point(52, 129);
            this.pbxThought.Margin = new System.Windows.Forms.Padding(2);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(79, 73);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 14;
            this.pbxThought.TabStop = false;
            // 
            // pbxBubble3
            // 
            this.pbxBubble3.Image = global::Year_13_Coursework.Properties.Resources.thoughtBubble3;
            this.pbxBubble3.Location = new System.Drawing.Point(13, 83);
            this.pbxBubble3.Margin = new System.Windows.Forms.Padding(2);
            this.pbxBubble3.Name = "pbxBubble3";
            this.pbxBubble3.Size = new System.Drawing.Size(150, 218);
            this.pbxBubble3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBubble3.TabIndex = 10;
            this.pbxBubble3.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(13, 305);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(150, 132);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxCountry
            // 
            this.pbxCountry.Location = new System.Drawing.Point(175, 83);
            this.pbxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCountry.Name = "pbxCountry";
            this.pbxCountry.Size = new System.Drawing.Size(434, 263);
            this.pbxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCountry.TabIndex = 0;
            this.pbxCountry.TabStop = false;
            // 
            // tmr2
            // 
            this.tmr2.Interval = 1000;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 479);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.pbxBubble3);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.pbxCountry);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 1";
            this.Activated += new System.EventHandler(this.FrmGame1_Activated);
            this.Load += new System.EventHandler(this.FrmGame1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).EndInit();
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
        private System.Windows.Forms.PictureBox pbxBubble3;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox pbxThought;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer tmr2;
    }
}
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
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxBubble3 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxCountry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(601, 544);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(320, 85);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Text = "Answer";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(270, 544);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(320, 85);
            this.btnAnswer1.TabIndex = 4;
            this.btnAnswer1.Text = "Answer";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(270, 640);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(320, 85);
            this.btnAnswer3.TabIndex = 5;
            this.btnAnswer3.Text = "Answer";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(601, 640);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(320, 85);
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Text = "Answer";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(767, 55);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(154, 60);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "Timer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 55);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(161, 60);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(396, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 60);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.Tmr1_Tick);
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark1;
            this.pbxThought.Location = new System.Drawing.Point(74, 270);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(99, 83);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 14;
            this.pbxThought.TabStop = false;
            // 
            // pbxBubble3
            // 
            this.pbxBubble3.Image = global::Year_13_Coursework.Properties.Resources.thoughtBubble;
            this.pbxBubble3.Location = new System.Drawing.Point(12, 218);
            this.pbxBubble3.Name = "pbxBubble3";
            this.pbxBubble3.Size = new System.Drawing.Size(235, 247);
            this.pbxBubble3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBubble3.TabIndex = 10;
            this.pbxBubble3.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(12, 498);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(235, 227);
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            this.pbxAvatar.Click += new System.EventHandler(this.PbxAvatar_Click);
            // 
            // pbxCountry
            // 
            this.pbxCountry.Location = new System.Drawing.Point(270, 128);
            this.pbxCountry.Name = "pbxCountry";
            this.pbxCountry.Size = new System.Drawing.Size(651, 404);
            this.pbxCountry.TabIndex = 0;
            this.pbxCountry.TabStop = false;
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 737);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbxBubble3);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.pbxCountry);
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 1";
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
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox pbxThought;
    }
}
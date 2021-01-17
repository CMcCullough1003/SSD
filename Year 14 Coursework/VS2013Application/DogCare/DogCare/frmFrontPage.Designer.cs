namespace DogCare
{
    partial class frmFrontPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.mstCustomer = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayCareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileGroomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWalking = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnMobileGrooming = new System.Windows.Forms.Button();
            this.btngrooming = new System.Windows.Forms.Button();
            this.btnKennel = new System.Windows.Forms.Button();
            this.btnDayCare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mstCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 60);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 91);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "JD Dog Care";
            // 
            // mstCustomer
            // 
            this.mstCustomer.BackColor = System.Drawing.Color.White;
            this.mstCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dayCareToolStripMenuItem,
            this.kennelToolStripMenuItem,
            this.walkingToolStripMenuItem,
            this.trainingToolStripMenuItem,
            this.groomingToolStripMenuItem,
            this.mobileGroomingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mstCustomer.Location = new System.Drawing.Point(0, 0);
            this.mstCustomer.Name = "mstCustomer";
            this.mstCustomer.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mstCustomer.Size = new System.Drawing.Size(704, 28);
            this.mstCustomer.TabIndex = 18;
            this.mstCustomer.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dayCareToolStripMenuItem
            // 
            this.dayCareToolStripMenuItem.Name = "dayCareToolStripMenuItem";
            this.dayCareToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.dayCareToolStripMenuItem.Text = "Day Care";
            // 
            // kennelToolStripMenuItem
            // 
            this.kennelToolStripMenuItem.Name = "kennelToolStripMenuItem";
            this.kennelToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.kennelToolStripMenuItem.Text = "Kennel";
            // 
            // walkingToolStripMenuItem
            // 
            this.walkingToolStripMenuItem.Name = "walkingToolStripMenuItem";
            this.walkingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.walkingToolStripMenuItem.Text = "Walking";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // groomingToolStripMenuItem
            // 
            this.groomingToolStripMenuItem.Name = "groomingToolStripMenuItem";
            this.groomingToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.groomingToolStripMenuItem.Text = "Grooming";
            // 
            // mobileGroomingToolStripMenuItem
            // 
            this.mobileGroomingToolStripMenuItem.Name = "mobileGroomingToolStripMenuItem";
            this.mobileGroomingToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.mobileGroomingToolStripMenuItem.Text = "Mobile Grooming";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnWalking
            // 
            this.btnWalking.BackColor = System.Drawing.SystemColors.Control;
            this.btnWalking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalking.ForeColor = System.Drawing.Color.Black;
            this.btnWalking.Location = new System.Drawing.Point(22, 488);
            this.btnWalking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWalking.Name = "btnWalking";
            this.btnWalking.Size = new System.Drawing.Size(321, 58);
            this.btnWalking.TabIndex = 1;
            this.btnWalking.Tag = "2";
            this.btnWalking.Text = "Walking";
            this.btnWalking.UseVisualStyleBackColor = false;
            this.btnWalking.Click += new System.EventHandler(this.btnWalking_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.ForeColor = System.Drawing.Color.Black;
            this.btnTraining.Location = new System.Drawing.Point(360, 644);
            this.btnTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(321, 58);
            this.btnTraining.TabIndex = 6;
            this.btnTraining.Tag = "5";
            this.btnTraining.Text = "Training";
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnMobileGrooming
            // 
            this.btnMobileGrooming.BackColor = System.Drawing.SystemColors.Control;
            this.btnMobileGrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobileGrooming.ForeColor = System.Drawing.Color.Black;
            this.btnMobileGrooming.Location = new System.Drawing.Point(360, 568);
            this.btnMobileGrooming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMobileGrooming.Name = "btnMobileGrooming";
            this.btnMobileGrooming.Size = new System.Drawing.Size(321, 58);
            this.btnMobileGrooming.TabIndex = 4;
            this.btnMobileGrooming.Tag = "6";
            this.btnMobileGrooming.Text = "Mobile Grooming";
            this.btnMobileGrooming.UseVisualStyleBackColor = false;
            this.btnMobileGrooming.Click += new System.EventHandler(this.btnMobileGrooming_Click);
            // 
            // btngrooming
            // 
            this.btngrooming.BackColor = System.Drawing.SystemColors.Control;
            this.btngrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrooming.ForeColor = System.Drawing.Color.Black;
            this.btngrooming.Location = new System.Drawing.Point(22, 568);
            this.btngrooming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngrooming.Name = "btngrooming";
            this.btngrooming.Size = new System.Drawing.Size(321, 58);
            this.btngrooming.TabIndex = 3;
            this.btngrooming.Tag = "3";
            this.btngrooming.Text = "Grooming";
            this.btngrooming.UseVisualStyleBackColor = false;
            this.btngrooming.Click += new System.EventHandler(this.btngrooming_Click);
            // 
            // btnKennel
            // 
            this.btnKennel.BackColor = System.Drawing.SystemColors.Control;
            this.btnKennel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKennel.ForeColor = System.Drawing.Color.Black;
            this.btnKennel.Location = new System.Drawing.Point(22, 644);
            this.btnKennel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKennel.Name = "btnKennel";
            this.btnKennel.Size = new System.Drawing.Size(321, 58);
            this.btnKennel.TabIndex = 5;
            this.btnKennel.Tag = "4";
            this.btnKennel.Text = "Kennel";
            this.btnKennel.UseVisualStyleBackColor = false;
            this.btnKennel.Click += new System.EventHandler(this.btnKennel_Click);
            // 
            // btnDayCare
            // 
            this.btnDayCare.BackColor = System.Drawing.SystemColors.Control;
            this.btnDayCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayCare.ForeColor = System.Drawing.Color.Black;
            this.btnDayCare.Location = new System.Drawing.Point(360, 488);
            this.btnDayCare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDayCare.Name = "btnDayCare";
            this.btnDayCare.Size = new System.Drawing.Size(321, 58);
            this.btnDayCare.TabIndex = 2;
            this.btnDayCare.Tag = "1";
            this.btnDayCare.Text = "Day Care";
            this.btnDayCare.UseVisualStyleBackColor = false;
            this.btnDayCare.Click += new System.EventHandler(this.btnDayCare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DogCare.Properties.Resources.dog_moustache;
            this.pictureBox1.Location = new System.Drawing.Point(194, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDayCare);
            this.Controls.Add(this.btnKennel);
            this.Controls.Add(this.btngrooming);
            this.Controls.Add(this.btnMobileGrooming);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnWalking);
            this.Controls.Add(this.mstCustomer);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JD Dog Care";
            this.mstCustomer.ResumeLayout(false);
            this.mstCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mstCustomer;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayCareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileGroomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnWalking;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnMobileGrooming;
        private System.Windows.Forms.Button btngrooming;
        private System.Windows.Forms.Button btnKennel;
        private System.Windows.Forms.Button btnDayCare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
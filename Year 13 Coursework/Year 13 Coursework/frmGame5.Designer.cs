namespace Year_13_Coursework
{
    partial class frmGame5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame5));
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectGuessCount = new System.Windows.Forms.Label();
            this.lblSaltonSea = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBrusselSea = new System.Windows.Forms.Label();
            this.lblArafuraSea = new System.Windows.Forms.Label();
            this.lblBoySea = new System.Windows.Forms.Label();
            this.lblWeddellSea = new System.Windows.Forms.Label();
            this.lblBadSea = new System.Windows.Forms.Label();
            this.lblTasmanSea = new System.Windows.Forms.Label();
            this.lblOtisSea = new System.Windows.Forms.Label();
            this.lblDylanSea = new System.Windows.Forms.Label();
            this.lblEltonSea = new System.Windows.Forms.Label();
            this.lblTempleSea = new System.Windows.Forms.Label();
            this.lblSeaOfPlato = new System.Windows.Forms.Label();
            this.lblSeaOfStorms = new System.Windows.Forms.Label();
            this.lblPiSea = new System.Windows.Forms.Label();
            this.lblTiSea = new System.Windows.Forms.Label();
            this.lblSiSea = new System.Windows.Forms.Label();
            this.lblBrysSea = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSkipGame = new System.Windows.Forms.Button();
            this.pbxSea = new System.Windows.Forms.PictureBox();
            this.pbxThought = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxYacht = new System.Windows.Forms.PictureBox();
            this.pbxSky = new System.Windows.Forms.PictureBox();
            this.pbxCountry = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYacht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(388, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 152;
            this.label3.Text = "Current score:";
            // 
            // lblCorrectGuessCount
            // 
            this.lblCorrectGuessCount.AutoSize = true;
            this.lblCorrectGuessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectGuessCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorrectGuessCount.Location = new System.Drawing.Point(523, 610);
            this.lblCorrectGuessCount.Name = "lblCorrectGuessCount";
            this.lblCorrectGuessCount.Size = new System.Drawing.Size(55, 32);
            this.lblCorrectGuessCount.TabIndex = 151;
            this.lblCorrectGuessCount.Text = "0/4";
            this.lblCorrectGuessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaltonSea
            // 
            this.lblSaltonSea.AutoSize = true;
            this.lblSaltonSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSaltonSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaltonSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltonSea.ForeColor = System.Drawing.Color.White;
            this.lblSaltonSea.Location = new System.Drawing.Point(392, 472);
            this.lblSaltonSea.Name = "lblSaltonSea";
            this.lblSaltonSea.Size = new System.Drawing.Size(157, 34);
            this.lblSaltonSea.TabIndex = 150;
            this.lblSaltonSea.Tag = "";
            this.lblSaltonSea.Text = "Salton Sea";
            this.lblSaltonSea.Click += new System.EventHandler(this.LblSaltonSea_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(1046, 595);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(93, 51);
            this.btnHelp.TabIndex = 121;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(1042, 183);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(48, 20);
            this.lblTimer.TabIndex = 120;
            this.lblTimer.Text = "Timer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(1042, 246);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 119;
            this.lblScore.Text = "Score";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(376, 134);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 46);
            this.lblTitle.TabIndex = 117;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.BackColor = System.Drawing.Color.White;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreCount.Location = new System.Drawing.Point(1042, 266);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(31, 32);
            this.lblScoreCount.TabIndex = 116;
            this.lblScoreCount.Text = "0";
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BackColor = System.Drawing.Color.White;
            this.lblTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimerCount.Location = new System.Drawing.Point(1042, 203);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(47, 32);
            this.lblTimerCount.TabIndex = 115;
            this.lblTimerCount.Text = "10";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblBrusselSea
            // 
            this.lblBrusselSea.AutoSize = true;
            this.lblBrusselSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBrusselSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrusselSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrusselSea.ForeColor = System.Drawing.Color.White;
            this.lblBrusselSea.Location = new System.Drawing.Point(556, 472);
            this.lblBrusselSea.Name = "lblBrusselSea";
            this.lblBrusselSea.Size = new System.Drawing.Size(170, 34);
            this.lblBrusselSea.TabIndex = 155;
            this.lblBrusselSea.Tag = "";
            this.lblBrusselSea.Text = "Brussel Sea";
            this.lblBrusselSea.Click += new System.EventHandler(this.LblBrusselSea_Click);
            // 
            // lblArafuraSea
            // 
            this.lblArafuraSea.AutoSize = true;
            this.lblArafuraSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblArafuraSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArafuraSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArafuraSea.ForeColor = System.Drawing.Color.White;
            this.lblArafuraSea.Location = new System.Drawing.Point(732, 472);
            this.lblArafuraSea.Name = "lblArafuraSea";
            this.lblArafuraSea.Size = new System.Drawing.Size(168, 34);
            this.lblArafuraSea.TabIndex = 156;
            this.lblArafuraSea.Tag = "";
            this.lblArafuraSea.Text = "Arafura Sea";
            this.lblArafuraSea.Click += new System.EventHandler(this.LblArafuraSea_Click);
            // 
            // lblBoySea
            // 
            this.lblBoySea.AutoSize = true;
            this.lblBoySea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBoySea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoySea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoySea.ForeColor = System.Drawing.Color.White;
            this.lblBoySea.Location = new System.Drawing.Point(907, 472);
            this.lblBoySea.Name = "lblBoySea";
            this.lblBoySea.Size = new System.Drawing.Size(124, 34);
            this.lblBoySea.TabIndex = 157;
            this.lblBoySea.Tag = "";
            this.lblBoySea.Text = "Boy Sea";
            this.lblBoySea.Click += new System.EventHandler(this.LblBoySea_Click);
            // 
            // lblWeddellSea
            // 
            this.lblWeddellSea.AutoSize = true;
            this.lblWeddellSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblWeddellSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeddellSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeddellSea.ForeColor = System.Drawing.Color.White;
            this.lblWeddellSea.Location = new System.Drawing.Point(392, 510);
            this.lblWeddellSea.Name = "lblWeddellSea";
            this.lblWeddellSea.Size = new System.Drawing.Size(179, 34);
            this.lblWeddellSea.TabIndex = 158;
            this.lblWeddellSea.Tag = "";
            this.lblWeddellSea.Text = "Weddell Sea";
            this.lblWeddellSea.Click += new System.EventHandler(this.LblWeddellSea_Click);
            // 
            // lblBadSea
            // 
            this.lblBadSea.AutoSize = true;
            this.lblBadSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBadSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBadSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadSea.ForeColor = System.Drawing.Color.White;
            this.lblBadSea.Location = new System.Drawing.Point(582, 510);
            this.lblBadSea.Name = "lblBadSea";
            this.lblBadSea.Size = new System.Drawing.Size(126, 34);
            this.lblBadSea.TabIndex = 159;
            this.lblBadSea.Tag = "";
            this.lblBadSea.Text = "Bad Sea";
            this.lblBadSea.Click += new System.EventHandler(this.LblBadSea_Click);
            // 
            // lblTasmanSea
            // 
            this.lblTasmanSea.AutoSize = true;
            this.lblTasmanSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTasmanSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTasmanSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasmanSea.ForeColor = System.Drawing.Color.White;
            this.lblTasmanSea.Location = new System.Drawing.Point(718, 510);
            this.lblTasmanSea.Name = "lblTasmanSea";
            this.lblTasmanSea.Size = new System.Drawing.Size(177, 34);
            this.lblTasmanSea.TabIndex = 160;
            this.lblTasmanSea.Tag = "";
            this.lblTasmanSea.Text = "Tasman Sea";
            this.lblTasmanSea.Click += new System.EventHandler(this.LblTasmanSea_Click);
            // 
            // lblOtisSea
            // 
            this.lblOtisSea.AutoSize = true;
            this.lblOtisSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblOtisSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtisSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtisSea.ForeColor = System.Drawing.Color.White;
            this.lblOtisSea.Location = new System.Drawing.Point(905, 510);
            this.lblOtisSea.Name = "lblOtisSea";
            this.lblOtisSea.Size = new System.Drawing.Size(126, 34);
            this.lblOtisSea.TabIndex = 161;
            this.lblOtisSea.Tag = "";
            this.lblOtisSea.Text = "Otis Sea";
            this.lblOtisSea.Click += new System.EventHandler(this.LblOtisSea_Click);
            // 
            // lblDylanSea
            // 
            this.lblDylanSea.AutoSize = true;
            this.lblDylanSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDylanSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDylanSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDylanSea.ForeColor = System.Drawing.Color.White;
            this.lblDylanSea.Location = new System.Drawing.Point(392, 548);
            this.lblDylanSea.Name = "lblDylanSea";
            this.lblDylanSea.Size = new System.Drawing.Size(148, 34);
            this.lblDylanSea.TabIndex = 162;
            this.lblDylanSea.Tag = "";
            this.lblDylanSea.Text = "Dylan Sea";
            this.lblDylanSea.Click += new System.EventHandler(this.LblDylanSea_Click);
            // 
            // lblEltonSea
            // 
            this.lblEltonSea.AutoSize = true;
            this.lblEltonSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEltonSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEltonSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEltonSea.ForeColor = System.Drawing.Color.White;
            this.lblEltonSea.Location = new System.Drawing.Point(717, 548);
            this.lblEltonSea.Name = "lblEltonSea";
            this.lblEltonSea.Size = new System.Drawing.Size(141, 34);
            this.lblEltonSea.TabIndex = 164;
            this.lblEltonSea.Tag = "";
            this.lblEltonSea.Text = "Elton Sea";
            this.lblEltonSea.Click += new System.EventHandler(this.LblEltonSea_Click);
            // 
            // lblTempleSea
            // 
            this.lblTempleSea.AutoSize = true;
            this.lblTempleSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTempleSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempleSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempleSea.ForeColor = System.Drawing.Color.White;
            this.lblTempleSea.Location = new System.Drawing.Point(861, 548);
            this.lblTempleSea.Name = "lblTempleSea";
            this.lblTempleSea.Size = new System.Drawing.Size(170, 34);
            this.lblTempleSea.TabIndex = 165;
            this.lblTempleSea.Tag = "";
            this.lblTempleSea.Text = "Temple Sea";
            this.lblTempleSea.Click += new System.EventHandler(this.LblTempleSea_Click);
            // 
            // lblSeaOfPlato
            // 
            this.lblSeaOfPlato.AutoSize = true;
            this.lblSeaOfPlato.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSeaOfPlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeaOfPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeaOfPlato.ForeColor = System.Drawing.Color.White;
            this.lblSeaOfPlato.Location = new System.Drawing.Point(542, 548);
            this.lblSeaOfPlato.Name = "lblSeaOfPlato";
            this.lblSeaOfPlato.Size = new System.Drawing.Size(172, 34);
            this.lblSeaOfPlato.TabIndex = 163;
            this.lblSeaOfPlato.Tag = "";
            this.lblSeaOfPlato.Text = "Sea of Plato";
            this.lblSeaOfPlato.Click += new System.EventHandler(this.LblSeaOfPlato_Click);
            // 
            // lblSeaOfStorms
            // 
            this.lblSeaOfStorms.AutoSize = true;
            this.lblSeaOfStorms.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSeaOfStorms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeaOfStorms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeaOfStorms.ForeColor = System.Drawing.Color.White;
            this.lblSeaOfStorms.Location = new System.Drawing.Point(392, 435);
            this.lblSeaOfStorms.Name = "lblSeaOfStorms";
            this.lblSeaOfStorms.Size = new System.Drawing.Size(195, 34);
            this.lblSeaOfStorms.TabIndex = 166;
            this.lblSeaOfStorms.Tag = "";
            this.lblSeaOfStorms.Text = "Sea of Storms";
            this.lblSeaOfStorms.Click += new System.EventHandler(this.LblSeaOfStorms_Click);
            // 
            // lblPiSea
            // 
            this.lblPiSea.AutoSize = true;
            this.lblPiSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPiSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPiSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiSea.ForeColor = System.Drawing.Color.White;
            this.lblPiSea.Location = new System.Drawing.Point(590, 435);
            this.lblPiSea.Name = "lblPiSea";
            this.lblPiSea.Size = new System.Drawing.Size(101, 34);
            this.lblPiSea.TabIndex = 167;
            this.lblPiSea.Tag = "";
            this.lblPiSea.Text = "Pi Sea";
            this.lblPiSea.Click += new System.EventHandler(this.LblPiSea_Click);
            // 
            // lblTiSea
            // 
            this.lblTiSea.AutoSize = true;
            this.lblTiSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTiSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTiSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiSea.ForeColor = System.Drawing.Color.White;
            this.lblTiSea.Location = new System.Drawing.Point(694, 435);
            this.lblTiSea.Name = "lblTiSea";
            this.lblTiSea.Size = new System.Drawing.Size(99, 34);
            this.lblTiSea.TabIndex = 168;
            this.lblTiSea.Tag = "";
            this.lblTiSea.Text = "Ti Sea";
            this.lblTiSea.Click += new System.EventHandler(this.LblTiSea_Click);
            // 
            // lblSiSea
            // 
            this.lblSiSea.AutoSize = true;
            this.lblSiSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSiSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSiSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiSea.ForeColor = System.Drawing.Color.White;
            this.lblSiSea.Location = new System.Drawing.Point(796, 435);
            this.lblSiSea.Name = "lblSiSea";
            this.lblSiSea.Size = new System.Drawing.Size(101, 34);
            this.lblSiSea.TabIndex = 169;
            this.lblSiSea.Tag = "";
            this.lblSiSea.Text = "Si Sea";
            this.lblSiSea.Click += new System.EventHandler(this.LblSiSea_Click);
            // 
            // lblBrysSea
            // 
            this.lblBrysSea.AutoSize = true;
            this.lblBrysSea.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBrysSea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrysSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrysSea.ForeColor = System.Drawing.Color.White;
            this.lblBrysSea.Location = new System.Drawing.Point(900, 435);
            this.lblBrysSea.Name = "lblBrysSea";
            this.lblBrysSea.Size = new System.Drawing.Size(131, 34);
            this.lblBrysSea.TabIndex = 170;
            this.lblBrysSea.Tag = "";
            this.lblBrysSea.Text = "Brys Sea";
            this.lblBrysSea.Click += new System.EventHandler(this.LblBrysSea_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.ForeColor = System.Drawing.Color.White;
            this.btnSubmitAnswer.Location = new System.Drawing.Point(714, 651);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(320, 54);
            this.btnSubmitAnswer.TabIndex = 171;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.BtnSubmitAnswer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(714, 595);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(320, 54);
            this.btnClear.TabIndex = 172;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSkipGame
            // 
            this.btnSkipGame.Location = new System.Drawing.Point(1046, 652);
            this.btnSkipGame.Name = "btnSkipGame";
            this.btnSkipGame.Size = new System.Drawing.Size(93, 53);
            this.btnSkipGame.TabIndex = 220;
            this.btnSkipGame.Text = "Skip";
            this.btnSkipGame.UseVisualStyleBackColor = true;
            this.btnSkipGame.Click += new System.EventHandler(this.BtnSkipGame_Click);
            // 
            // pbxSea
            // 
            this.pbxSea.Image = global::Year_13_Coursework.Properties.Resources.sea;
            this.pbxSea.Location = new System.Drawing.Point(384, 283);
            this.pbxSea.Name = "pbxSea";
            this.pbxSea.Size = new System.Drawing.Size(652, 146);
            this.pbxSea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSea.TabIndex = 153;
            this.pbxSea.TabStop = false;
            // 
            // pbxThought
            // 
            this.pbxThought.Image = global::Year_13_Coursework.Properties.Resources.questionMark21;
            this.pbxThought.Location = new System.Drawing.Point(1046, 403);
            this.pbxThought.Name = "pbxThought";
            this.pbxThought.Size = new System.Drawing.Size(92, 89);
            this.pbxThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThought.TabIndex = 118;
            this.pbxThought.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(1046, 498);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(92, 89);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 113;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxYacht
            // 
            this.pbxYacht.BackColor = System.Drawing.Color.Transparent;
            this.pbxYacht.Image = global::Year_13_Coursework.Properties.Resources.yacht;
            this.pbxYacht.Location = new System.Drawing.Point(479, 195);
            this.pbxYacht.Name = "pbxYacht";
            this.pbxYacht.Size = new System.Drawing.Size(99, 95);
            this.pbxYacht.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxYacht.TabIndex = 154;
            this.pbxYacht.TabStop = false;
            // 
            // pbxSky
            // 
            this.pbxSky.Image = global::Year_13_Coursework.Properties.Resources.sky;
            this.pbxSky.Location = new System.Drawing.Point(384, 183);
            this.pbxSky.Name = "pbxSky";
            this.pbxSky.Size = new System.Drawing.Size(652, 102);
            this.pbxSky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSky.TabIndex = 123;
            this.pbxSky.TabStop = false;
            // 
            // pbxCountry
            // 
            this.pbxCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCountry.Location = new System.Drawing.Point(384, 183);
            this.pbxCountry.Name = "pbxCountry";
            this.pbxCountry.Size = new System.Drawing.Size(652, 404);
            this.pbxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCountry.TabIndex = 219;
            this.pbxCountry.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(352, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 630);
            this.pictureBox1.TabIndex = 218;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Year_13_Coursework.Properties.Resources.game6BG;
            this.pictureBox2.Location = new System.Drawing.Point(-9, -66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1570, 1016);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 221;
            this.pictureBox2.TabStop = false;
            // 
            // frmGame5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1514, 858);
            this.Controls.Add(this.btnSkipGame);
            this.Controls.Add(this.pbxSea);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblBrysSea);
            this.Controls.Add(this.lblSiSea);
            this.Controls.Add(this.lblTiSea);
            this.Controls.Add(this.lblPiSea);
            this.Controls.Add(this.lblSeaOfStorms);
            this.Controls.Add(this.lblTempleSea);
            this.Controls.Add(this.lblEltonSea);
            this.Controls.Add(this.lblSeaOfPlato);
            this.Controls.Add(this.lblDylanSea);
            this.Controls.Add(this.lblOtisSea);
            this.Controls.Add(this.lblTasmanSea);
            this.Controls.Add(this.lblBadSea);
            this.Controls.Add(this.lblWeddellSea);
            this.Controls.Add(this.lblBoySea);
            this.Controls.Add(this.lblArafuraSea);
            this.Controls.Add(this.lblBrusselSea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCorrectGuessCount);
            this.Controls.Add(this.lblSaltonSea);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxThought);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.pbxYacht);
            this.Controls.Add(this.pbxSky);
            this.Controls.Add(this.pbxCountry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGame5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 5";
            this.Activated += new System.EventHandler(this.FrmGame5_Activated);
            this.Load += new System.EventHandler(this.FrmGame5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYacht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectGuessCount;
        private System.Windows.Forms.Label lblSaltonSea;
        private System.Windows.Forms.PictureBox pbxSky;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbxThought;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxSea;
        private System.Windows.Forms.PictureBox pbxYacht;
        private System.Windows.Forms.Label lblBrusselSea;
        private System.Windows.Forms.Label lblArafuraSea;
        private System.Windows.Forms.Label lblBoySea;
        private System.Windows.Forms.Label lblWeddellSea;
        private System.Windows.Forms.Label lblBadSea;
        private System.Windows.Forms.Label lblTasmanSea;
        private System.Windows.Forms.Label lblOtisSea;
        private System.Windows.Forms.Label lblDylanSea;
        private System.Windows.Forms.Label lblEltonSea;
        private System.Windows.Forms.Label lblTempleSea;
        private System.Windows.Forms.Label lblSeaOfPlato;
        private System.Windows.Forms.Label lblSeaOfStorms;
        private System.Windows.Forms.Label lblPiSea;
        private System.Windows.Forms.Label lblTiSea;
        private System.Windows.Forms.Label lblSiSea;
        private System.Windows.Forms.Label lblBrysSea;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxCountry;
        private System.Windows.Forms.Button btnSkipGame;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
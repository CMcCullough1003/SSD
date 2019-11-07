using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_13_Coursework.Tools;

namespace Year_13_Coursework
{
    public partial class frmGame2 : frmGame
    {

        private int counter = 30;

        int countryPosition = 0;
        int clue1Position = 1;
        int clue2Position = 2;
        int clue3Position = 3;
        int image1Position = 4;
        int image2Position = 5;
        int image3Position = 6;
        int selectedCountry = 0;

        int whichClueVisible = 0;

        int countryCount = 6;

        string[,] clues = new string[7, 7] { 
            { "Norway", "Northern lights", "Midnight sun", "Fjords", "norway2.jpg", "norway2.jpg", "norway3.jpg" },
            { "Morrocco", "Mint Tea", "Atlas Mountains", "Sahara Desert", "morrocco2.jpg", "morrocco1.jpg", "morrocco3.jpg" },
            { "Denmark", "Lurpak", "Vikings", "Lego", "denmark1.jpg", "denmark2.jpg", "denmark3.jpg" },
            { "Sweden", "Volvo", "ABBA", "IKEA", "sweden1.jpg", "sweden2.jpg", "sweden3.jpg"},
            { "Greece", "Olives", "Marathon", "Acropolis", "greece1.jpg", "greece2.jpg", "greece3.jpg" },
            { "Canada", "Bears", "Ice Hockey", "Maple Syrup", "canada1.jpg", "canada2.jpg", "canada3.jpg" },
            { "Finland", "Moomins", "Valtteri Bottas", "Lapland", "finland1.jpg", "finland2.jpg", "finland3.jpg" }
        };

        public frmGame2()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame2_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
            chooseCountry();
            displayFirstClues();
        }

        //The form is shown after frmMenu closes
        private void FrmGame2_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //The timer countdown
        private void Timer1_Tick(object sender, EventArgs e)
        {
            displayCountdown();
        }

        //Stops the form being moved so the menu form is always on top of the game
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        /* BUTTON CLICKS  ======================================================================*/

        private void BtnSubmitAnswer_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToNextScreen();
        }

        /* MY METHODS ======================================================================*/

        private void playGame()
        {
        }

        private void setUpTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            lblTimerCount.Text = counter.ToString();
        }

        private void displayCountdown()
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                pbxThought.Image = Properties.Resources.alarmClock;
            }
            lblTimerCount.Text = counter.ToString();
        }

        private void setTitle()
        {
            GameInfo gameInfo = new GameInfo();
            lblTitle.Text = gameInfo.gameName();
        }

        private void displayAvatar()
        {
            Avatars avatar = new Avatars();
            pbxAvatar.Image = avatar.getAvatarImage(Program.currentUser.currentAvatar);
        }

        private void moveToMenuScreen()
        {
            Form moveToMenu = new frmGameMenu();
            moveToMenu.Show();
        }

        private void BtnNextClue_Click(object sender, EventArgs e)
        {
            whichClueVisible++;

            switch (whichClueVisible)
            {
                case 1: displaySecondClues(); break;
                case 2: displayThirdClues(); break;
            }
        }

        private void chooseCountry()
        {
            Random random = new Random();
            selectedCountry = random.Next(0, clues.GetLength(0) - 1);
        }

        private void displayFirstClues()
        {
            switch(clues[selectedCountry, countryPosition])
            {
                case "Norway": pbxClue1.Image = Properties.Resources.norway1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Morrocco":
                    pbxClue1.Image = Properties.Resources.morrocco1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Denmark":
                    pbxClue1.Image = Properties.Resources.denmark1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Sweden":
                    pbxClue1.Image = Properties.Resources.sweden1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Greece":
                    pbxClue1.Image = Properties.Resources.greece1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Canada":
                    pbxClue1.Image = Properties.Resources.canada1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
                case "Finland":
                    pbxClue1.Image = Properties.Resources.finland1;
                    lblHint1.Text = clues[selectedCountry, clue1Position]; break;
            }
        }

        private void displaySecondClues()
        {
            switch (clues[selectedCountry, countryPosition])
            {
                case "Norway":
                    pbxClue2.Image = Properties.Resources.norway2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Morrocco":
                    pbxClue2.Image = Properties.Resources.morrocco2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Denmark":
                    pbxClue2.Image = Properties.Resources.denmark2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Sweden":
                    pbxClue2.Image = Properties.Resources.sweden2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Greece":
                    pbxClue2.Image = Properties.Resources.greece2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Canada":
                    pbxClue2.Image = Properties.Resources.canada2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
                case "Finland":
                    pbxClue2.Image = Properties.Resources.finland2;
                    lblHint2.Text = clues[selectedCountry, clue2Position]; break;
            }
        }

        private void displayThirdClues()
        {
            switch (clues[selectedCountry, countryPosition])
            {
                case "Norway":
                    pbxClue3.Image = Properties.Resources.norway3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Morrocco":
                    pbxClue3.Image = Properties.Resources.morrocco3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Denmark":
                    pbxClue3.Image = Properties.Resources.denmark3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Sweden":
                    pbxClue3.Image = Properties.Resources.sweden3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Greece":
                    pbxClue3.Image = Properties.Resources.greece3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Canada":
                    pbxClue3.Image = Properties.Resources.canada3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
                case "Finland":
                    pbxClue3.Image = Properties.Resources.finland3;
                    lblHint3.Text = clues[selectedCountry, clue3Position]; break;
            }
        }
    }
}

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
using Year_13_Coursework.Constants;

namespace Year_13_Coursework
{
    public partial class frmGame3 : frmGame
    {
        private int counter = 30;
        int score = 10;
        string selectedFlag = "";

        private string[] flagArray = new string[] { "algeria", "brazil", "cameroon", "czech republic", "egypt", "greenland", "hong kong", "mexico", "netherlands", "norway", "sweden", "uganda", "wales" };

        public frmGame3()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame3_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
            displayScore();
        }

        //The form is shown after frmMenu closes
        private void FrmGame3_Activated(object sender, EventArgs e)
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
            Strings strings = new Strings();
            
            if (strings.wasCorrectAnswerEntered(tbxGuess.Text, selectedFlag))
            {
                correctAnswer();
            }
            else
            {
                incorrectAnswer();
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToMenuScreen();
        }


        /* MY METHODS ======================================================================*/

        private void playGame()
        {
            displayFlag();
            displayAvatar();
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
                timedOut();
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

        private void PbxHide1_Click(object sender, EventArgs e)
        {
            pbxHide1.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide2_Click(object sender, EventArgs e)
        {
            pbxHide2.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide3_Click(object sender, EventArgs e)
        {
            pbxHide3.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide4_Click(object sender, EventArgs e)
        {
            pbxHide4.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide5_Click(object sender, EventArgs e)
        {
            pbxHide5.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide6_Click(object sender, EventArgs e)
        {
            pbxHide6.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide7_Click(object sender, EventArgs e)
        {
            pbxHide7.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide8_Click(object sender, EventArgs e)
        {
            pbxHide8.Visible = false;
            score -= 1;
            displayScore();
        }

        private void PbxHide9_Click(object sender, EventArgs e)
        {
            pbxHide9.Visible = false;
            score -= 1;
            displayScore();
        }

        private void displayFlag()
        {
            Random random = new Random();
            int position = random.Next(0, flagArray.Length - 1);
            selectedFlag = flagArray[position];

            switch (flagArray[position])
            {
                case "algeria": pbxFlag.Image = Properties.Resources.Algeria_Flag; break;
                case "brazil": pbxFlag.Image = Properties.Resources.Brazil_Flag; break;
                case "cameroon": pbxFlag.Image = Properties.Resources.Cameroon_Flag; break;
                case "czech republic": pbxFlag.Image = Properties.Resources.Czech_Republic_Flag; break;
                case "egypt": pbxFlag.Image = Properties.Resources.Egypt_Flag; break;
                case "greenland": pbxFlag.Image = Properties.Resources.Greenland_Flag; break;
                case "hong kong": pbxFlag.Image = Properties.Resources.Hong_Kong_Flag; break;
                case "mexico": pbxFlag.Image = Properties.Resources.Mexico_Flag; break;
                case "netherlands": pbxFlag.Image = Properties.Resources.Netherlands_Flag; break;
                case "norway": pbxFlag.Image = Properties.Resources.Norway_Flag; break;
                case "sweden": pbxFlag.Image = Properties.Resources.Sweden_Flag; break;
                case "uganda": pbxFlag.Image = Properties.Resources.Uganda_Flag; break;
                case "wales": pbxFlag.Image = Properties.Resources.Wales_Flag; break;
            }
        }

        private async void correctAnswer()
        {
            pbxThought.Image = Properties.Resources.Untitled;
            lblScoreCount.Text = score.ToString();
            saveScore(score);
            timer1.Stop();
            timer1 = null;

            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);

            moveToNextScreen();
        }

        private async void incorrectAnswer()
        {
            pbxThought.Image = Properties.Resources.X;

            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);

            pbxThought.Image = Properties.Resources.questionMark2;
            tbxGuess.Clear();
            tbxGuess.Focus();
        }

        private void displayScore()
        {
            lblScoreCount.Text = score.ToString();
        }

        private async void timedOut()
        {
            revealFlag();
            timer1.Stop();
            timer1 = null;
            pbxThought.Image = Properties.Resources.alarmClock;
            disableAllButtons();

            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);

            moveToNextScreen();
        }

 
        private void disableAllButtons()
        {
            btnHelp.Enabled = false;
            btnSubmitAnswer.Enabled = false;
        }

        private void revealFlag()
        {
            tbxGuess.Text = selectedFlag;
            pbxHide1.Visible = false;
            pbxHide2.Visible = false;
            pbxHide3.Visible = false;
            pbxHide4.Visible = false;
            pbxHide5.Visible = false;
            pbxHide6.Visible = false;
            pbxHide7.Visible = false;
            pbxHide8.Visible = false;
            pbxHide9.Visible = false;
        }

        private void LblSkipGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToNextScreen();
        }
    }
}

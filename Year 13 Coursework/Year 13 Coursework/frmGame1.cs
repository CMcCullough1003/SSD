using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_13_Coursework.Properties;
using Year_13_Coursework.Tools;
using System.Diagnostics;

namespace Year_13_Coursework
{
    public partial class frmGame1 : frmGame
    {
        private string selectedMap = "";
        private int mapCount = 0;
        string[] possibleAnswers = { "", "", "", "" };

        private const string albania = "albania.jpg";
        private const string belarus = "belarus.jpg";
        private const string denmark = "denmark.jpg";
        private const string finland = "finland.jpg";
        private const string france = "france.jpg";
        private const string germany = "germany.jpg";
        private const string greece = "greece.jpg";
        private const string iceland = "iceland.jpg";
        private const string ireland = "ireland.jpg";
        private const string italy = "italy.jpg";
        private const string norway = "norway.jpg";
        private const string poland = "poland.jpg";
        private const string portugal = "portugal.jpg";
        private const string russia = "russia.jpg";
        private const string serbia = "serbia.jpg";
        private const string spain = "spain.jpg";
        private const string sweden = "sweden.jpg";
        private const string switzerland = "switzerland.jpg";
        private const string turkey = "turkey.jpg";
        private const string ukraine = "ukraine.jpg";
        private int score = 0;

        private int counter = 30;
        private string[] countryArray = new string[] { albania, belarus, denmark, finland, france, germany, greece, iceland, ireland, italy, norway, poland, portugal, russia, serbia, spain, sweden, switzerland, turkey, ukraine };
        private Files files = new Files();

        public frmGame1()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame1_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
        }

        //The timer continues once frmMenu closes
        private void FrmGame1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //The timer countdown
        private void tmr1_Tick(object sender, EventArgs e)
        {
            displayCountdown();
        }

        //MY METHODS ------------------------------------------------------------------------------------------------------

        private async void playGame()
        {
            if (mapCount > 0)
            {
                //Pause for one and a half seconds to allow the game to display feedback to the user's answer
                await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
            }

            if (mapCount == 6)
            {
                if (timer1 != null)
                {
                    timer1.Stop();
                    timer1 = null;
                    moveToNextScreen();
                }
            }

            resetGame();
            displayMap();
            generateWrongAnswers();
            removeAllExtensions();
            displayAllButtons();
        }

        private void resetGame()
        {
            enableAllButtons();
            btnAnswer1.Focus();
            btnAnswer1.BackColor = System.Drawing.Color.SaddleBrown;
            btnAnswer2.BackColor = System.Drawing.Color.SaddleBrown;
            btnAnswer3.BackColor = System.Drawing.Color.SaddleBrown;
            btnAnswer4.BackColor = System.Drawing.Color.SaddleBrown;
            selectedMap = "";
            possibleAnswers[0] = "";
            possibleAnswers[1] = "";
            possibleAnswers[2] = "";
            possibleAnswers[3] = "";
            pbxThought.Image = Properties.Resources.questionMark2;
            mapCount++;
        }

        private void highlightCorrectAnswer()
        {
            if (btnAnswer1.Text == selectedMap)
            {
                btnAnswer1.BackColor = System.Drawing.Color.LawnGreen;
            }

            if (btnAnswer2.Text == selectedMap)
            {
                btnAnswer2.BackColor = System.Drawing.Color.LawnGreen;
            }

            if (btnAnswer3.Text == selectedMap)
            {
                btnAnswer3.BackColor = System.Drawing.Color.LawnGreen;
            }

            if (btnAnswer4.Text == selectedMap)
            {
                btnAnswer4.BackColor = System.Drawing.Color.LawnGreen;
            }
        }

        private void setUpTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(tmr1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            lblTimerCount.Text = counter.ToString();
        }

        //Counts down from 30
        private void displayCountdown()
        {
            counter--;
            if (counter == 0)
            {
                timedOut();

            }
            lblTimerCount.Text = counter.ToString();
        }

        private void disableAllButtons()
        {
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;
            btnHelp.Enabled = false;
            btnSkipGame.Enabled = false;
        }

        private void enableAllButtons()
        {
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            btnAnswer4.Enabled = true;
            btnHelp.Enabled = true;
            btnSkipGame.Enabled = true;
        }

        private void setTitle()
        {
            GameInfo gameInfo = new GameInfo();

            lblTitle.Text = gameInfo.gameName();
        }

        private void removeAllExtensions()
        {
            selectedMap = files.removeExtensions(possibleAnswers[0]);

            possibleAnswers[0] = files.removeExtensions(possibleAnswers[0]);
            possibleAnswers[1] = files.removeExtensions(possibleAnswers[1]);
            possibleAnswers[2] = files.removeExtensions(possibleAnswers[2]);
            possibleAnswers[3] = files.removeExtensions(possibleAnswers[3]);

            //Use alphabetical order to change where right answer might be
            Array.Sort(possibleAnswers);
        }

        private void displayAllButtons()
        {
            //Display the countries on the answer buttons
            btnAnswer1.Text = possibleAnswers[0];
            btnAnswer2.Text = possibleAnswers[1];
            btnAnswer3.Text = possibleAnswers[2];
            btnAnswer4.Text = possibleAnswers[3];
        }

        private void generateWrongAnswers()
        {
            possibleAnswers[0] = selectedMap;
            int positionToFill = 1;

            //Keep looping until all positions are filled
            while (possibleAnswers[3] == "")
            {
                //Find new country
                Random random = new Random();
                int position = random.Next(0, countryArray.Length - 1);
                string country = countryArray[position];

                //check if country already in array
                //-1 means it wasn't found in array
                int pos = Array.IndexOf(possibleAnswers, country);
                if (pos == -1)
                {
                    possibleAnswers[positionToFill] = country;
                    positionToFill++;
                }
            }
        }

        private void correctGuess()
        {
            pbxThought.Image = Resources.Childish_Tick_24982;
            score++;
            lblScoreCount.Text = score.ToString();
            saveScore(score);
            highlightCorrectAnswer();
            disableAllButtons();
            playGame();
        }

        private void incorrectGuess()
        {
            pbxThought.Image = Properties.Resources.Childish_Cross_24996;
            highlightCorrectAnswer();
            disableAllButtons();
            playGame();
        }

        private void displayAvatar()
        {
            Avatars avatar = new Avatars();
            pbxAvatar.Image = avatar.getAvatarImage(Program.currentUser.currentAvatar);
        }


        private void displayMap()
        {
            Random random = new Random();
            int position = random.Next(0, countryArray.Length - 1);
            selectedMap = countryArray[position];

            switch (countryArray[position])
            {
                case albania: pbxCountry.Image = Properties.Resources.albania; break;
                case belarus: pbxCountry.Image = Properties.Resources.belarus; break;
                case denmark: pbxCountry.Image = Properties.Resources.denmark; break;
                case finland: pbxCountry.Image = Properties.Resources.finland; break;
                case france: pbxCountry.Image = Properties.Resources.france; break;
                case germany: pbxCountry.Image = Properties.Resources.germany; break;
                case greece: pbxCountry.Image = Properties.Resources.greece; break;
                case iceland: pbxCountry.Image = Properties.Resources.iceland; break;
                case ireland: pbxCountry.Image = Properties.Resources.ireland; break;
                case italy: pbxCountry.Image = Properties.Resources.italy; break;
                case norway: pbxCountry.Image = Properties.Resources.norway; break;
                case poland: pbxCountry.Image = Properties.Resources.poland; break;
                case portugal: pbxCountry.Image = Properties.Resources.portugal; break;
                case russia: pbxCountry.Image = Properties.Resources.russia; break;
                case serbia: pbxCountry.Image = Properties.Resources.serbia; break;
                case spain: pbxCountry.Image = Properties.Resources.spain; break;
                case sweden: pbxCountry.Image = Properties.Resources.sweden; break;
                case switzerland: pbxCountry.Image = Properties.Resources.switzerland; break;
                case turkey: pbxCountry.Image = Properties.Resources.turkey; break;
                case ukraine: pbxCountry.Image = Properties.Resources.ukraine; break;
            }
        }

        private async void timedOut()
        {
            timer1.Stop();
            timer1 = null;
            pbxThought.Image = Properties.Resources.Childish_Clock_25009;

            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);

            moveToNextScreen();
        }

        private void BtnSkipGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToNextScreen();
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

        //CLICK EVENTS ------------------------------------------------------------------------------------------------

        private void BtnAnswer1_Click(object sender, EventArgs e)
        {
            if (btnAnswer1.Text == selectedMap)
            {
                correctGuess();
            }
            else
            {
                incorrectGuess();
            }
        }

        private void BtnAnswer2_Click(object sender, EventArgs e)
        {
            if (btnAnswer2.Text == selectedMap)
            {
                correctGuess();
            }
            else
            {
                incorrectGuess();
            }
        }

        private void BtnAnswer3_Click(object sender, EventArgs e)
        {
            if (btnAnswer3.Text == selectedMap)
            {
                correctGuess();
            }
            else
            {
                incorrectGuess();
            }
        }

        private void BtnAnswer4_Click(object sender, EventArgs e)
        {
            if (btnAnswer4.Text == selectedMap)
            {
                correctGuess();
            }
            else
            {
                incorrectGuess();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToMenuScreen();
        }

        //MOVE SCREENS ------------------------------------------------------------------------------------------------

        private void moveToMenuScreen()
        {
            Form moveToMenu = new frmGameMenu();
            moveToMenu.Show();
        }

        //The method moveToNextScreen is found in frmGame
    }
}

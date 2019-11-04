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

        private int counter = 10;
        private string[] countryArray = new string[] { albania, belarus, denmark, finland, france, germany, greece, iceland, ireland, italy, norway, poland, portugal, russia, serbia, spain, sweden, switzerland, turkey, ukraine };
        private Files files = new Files();

        public frmGame1()
        {
            InitializeComponent();

            tmr1 = new System.Windows.Forms.Timer();
            tmr1.Tick += new EventHandler(tmr1_Tick);
            tmr1.Interval = 1000;
            tmr1.Start();
            lblTimerCount.Text = counter.ToString();
        }

        private void FrmGame1_Load(object sender, EventArgs e)
        {
            displayAvatar();
            displayMap();
            generateWrongAnswers();
            removeAllExtensions();
            displayAllButtons();
            setTitle();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                tmr1.Stop();
                pbxThought.Image = Properties.Resources.alarmClock;
            }
            lblTimerCount.Text = counter.ToString();
        }

       /* CLICK METHODS ======================================================================*/

        private void Button1_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
        }

        private void BtnAnswer1_Click(object sender, EventArgs e)
        {
            if (btnAnswer1.Text == selectedMap)
            {
                correctGuess();
                btnAnswer1.BackColor = System.Drawing.Color.LawnGreen;
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
                btnAnswer2.BackColor = System.Drawing.Color.LawnGreen;
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
                btnAnswer3.BackColor = System.Drawing.Color.LawnGreen;
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
                btnAnswer4.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                incorrectGuess();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            moveToMenuScreen();
        }

        /* MY METHODS ======================================================================*/

        private void moveToMenuScreen()
        {
            Form moveToMenu = new frmGameMenu();
            moveToMenu.Show();
        }

        private void disableAllButtons()
        {
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;
            btnHelp.Enabled = false;
            
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

            //use alphabetical order to change where right answer might be
            Array.Sort(possibleAnswers);
        }

        private void displayAllButtons()
        {
            //put the countries on the answer buttons
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
            pbxThought.Image = Properties.Resources.Untitled;
            score++;
            lblScoreCount.Text = score.ToString();
            saveScore(score);
            tmr1.Stop();
            disableAllButtons();

        }

        private void incorrectGuess()
        {
            pbxThought.Image = Properties.Resources.X;
            tmr1.Stop();
            disableAllButtons();

        }

        private void displayAvatar()
        {
            pbxAvatar.Image = getAvatarImage(Program.currentUser.currentAvatar);
        }

        //pass in the filename of the current users avatar
        private Image getAvatarImage(string filename)
        {
            //default image so never returning a null
            Image image = Properties.Resources.bee;
            switch (filename)
            {
                case "bee.png": image = Properties.Resources.bee; break;
                case "chicken.png": image = Properties.Resources.chicken; break;
                case "elephant.png": image = Properties.Resources.elephant; break;
                case "cow.png": image = Properties.Resources.cow; break;
                case "pig.png": image = Properties.Resources.pig; break;
                case "triceratops.png": image = Properties.Resources.triceratops; break;
                case "dog.png": image = Properties.Resources.dog; break;
                case "ghost.png": image = Properties.Resources.ghost; break;
                case "sheep.png": image = Properties.Resources.sheep; break;
            }
            //switch on the name of the filename 
            //assign the image to the variable
            return image;
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
    }
}

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
    public partial class frmGame6 : frmGame
    {
        private const int maxCounter = 30;
        private int counter = maxCounter;
        private int currentStatement = 0;

        private const int statmentPosition = 0;
        private const int isStatementTruePosition = 1;

        private string[,] statements = new string[30, 2] {
            {"China is in Asia", "T"},
            {"Heated water turns to ice", "F"},
            {"The Lagan River flows through Glasgow", "F"},
            {"Australia is wider than the moon", "T"},
            {"90% of people live in the northen hemisphere", "T"},
            {"Monaco is the smallest country", "F"},
            {"Mt Everest is in Tibet", "T"},
            {"There are 7,100+ island in the Philippines", "T"},
            {"San Marino is completely surrounded by Italy", "T"},
            {"81 % of the Earth's surface is water", "F"},
            {"Toronto is the capital of Canada", "F"},
            {"Africa spans all four hemispheres", "T"},
            {"The 25 tallest mountain are in the Himalayas", "F"},
            {"The island nation of Naru has no capital city", "T"},
            {"It snowed in the Sahara in 2018", "T"},
            {"The are no rivers in Saudi Arabia", "T"},
            {"Nepal's flag is shaped like mountains", "T"},
            {"The United States and Russia are 51 miles part", "T"},
            {"All bears live in the Northen hemisphere", "F"},
            {"The US has land borders with 3 countries", "F"},
            {"Polar bears hunt penguins for food", "F"},
            {"Mount Everest can fit inside the Mariana Trench", "T"},
            {"There are no crocodiles in Australia", "F"},
            {"Every continent has acity called Rome", "F"},
            {"France has a village called Y", "T"},
            {"The coldest recorded temperature is -89.2C ", "T"},
            {"Iceland has more volcanoes tan any other country", "F"},
            {"Russia has 10 time zones", "F"},
            {"Hurricanes hit China more than any other country", "T"},
            {"Japan is west of India", "F"},
        };

        public frmGame6()
        {
            InitializeComponent();
        }

        private void FrmGame6_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
        }

        //The form is shown after frmMenu closes
        private void FrmGame6_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //The timer countdown
        private void Timer1_Tick(object sender, EventArgs e)
        {
            displayCountdown();
            dropStatements();
        }

        /* BUTTON CLICKS  ======================================================================*/

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToMenuScreen();
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

        private void dropStatements()
        {
            switch (counter)
            {
                case maxCounter: lblStatement1.Location = new Point(lblStatement1.Location.X, lblStatement1.Location.Y + 20); break;
                case maxCounter - 1: lblStatement2.Location = new Point(lblStatement2.Location.X, lblStatement2.Location.Y + 20); break;
                default: lblStatement3.Location = new Point(lblStatement3.Location.X, lblStatement3.Location.Y + 20); break;
            }
        }
    }
}

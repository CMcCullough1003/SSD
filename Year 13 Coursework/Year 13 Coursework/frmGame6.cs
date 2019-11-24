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
        private const int StatementYStartLocation = 25;
        private const int StatementYEndLocation = 275;
        private const int Statement1XPosition = 40;
        private const int Statement2XPosition = 170;
        private const int Statement3XPosition = 300;
        private const int YCoordinateMovePerTick = 20;

        private const string trueStatement = "T";
        private const string falseStatement = "F";
        private int clickedOrReachedBottomCount = 0;

        private const int maxCounter = 60;
        private int counter = maxCounter;
        private int currentStatement = 0;
        private int score = 0;

        private const int statementPosition = 0;
        private const int isStatementTruePosition = 1;

        private string[,] statements = new string[30, 2] {
            {"China is in Asia", "T"},
            {"Heated water turns\nto ice", "F"},
            {"The Lagan River flows\nthrough Glasgow", "F"},
            {"Australia is wider\nthan the moon", "T"},
            {"90% of people live\nin the northen\nhemisphere", "T"},
            {"Monaco is the\nsmallest country", "F"},
            {"Mt Everest is in\nTibet", "T"},
            {"There are 7,100+\nisland in the\nPhilippines", "T"},
            {"San Marino is\ncompletely surrounded\nby Italy", "T"},
            {"81 % of the Earth's\nsurface is water", "F"},
            {"Toronto is the\ncapital of Canada", "F"},
            {"Africa spans all\nfour hemispheres", "T"},
            {"The 25 tallest\nmountain are in\nthe Himalayas", "F"},
            {"The island nation\nof Naru has no\ncapital city", "T"},
            {"It snowed in the\nSahara in 2018", "T"},
            {"The are no rivers\nin Saudi Arabia", "T"},
            {"Nepal's flag is\nshaped like mountains", "T"},
            {"The United States\nand Russia are 51\nmiles part", "T"},
            {"All bears live in\nthe Northen hemisphere", "F"},
            {"The US has land\nborders with 3\ncountries", "F"},
            {"Polar bears hunt\npenguins for food", "F"},
            {"Mount Everest can\nfit inside the\nMariana Trench", "T"},
            {"There are no crocodiles\nin Australia", "F"},
            {"Every continent has\na city called Rome", "F"},
            {"France has a\nvillage called Y", "T"},
            {"The coldest recorded\ntemperature is\n-89.2C ", "T"},
            {"Iceland has more\nvolcanoes than any other\ncountry", "F"},
            {"Russia has 10\ntime zones", "F"},
            {"Hurricanes hit China\nmore than any other\ncountry", "T"},
            {"Japan is west of\nIndia", "F"},
        };

        public frmGame6()
        {
            InitializeComponent();
        }

        private void FrmGame6_Load(object sender, EventArgs e)
        {
            transparentMountainBackground();
            transparentCloudBackgrounds();
            addLabelsToBackground();
            addStatementToAllLabels();
            setUpTimer();
            displayAvatar();
            displayScore();
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

        private async void displayCountdown()
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                timer1 = null;
                pbxThought.Image = Properties.Resources.alarmClock;
                disableAllButtons();
                await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
                saveScore(score);
                moveToResultsScreen();
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
                case maxCounter - 1:
                    lblStatement1.Location = new Point(lblStatement1.Location.X, lblStatement1.Location.Y + YCoordinateMovePerTick);
                    break;
                case maxCounter - 2:
                    lblStatement1.Location = new Point(lblStatement1.Location.X, lblStatement1.Location.Y + YCoordinateMovePerTick);
                    lblStatement2.Location = new Point(lblStatement2.Location.X, lblStatement2.Location.Y + YCoordinateMovePerTick);
                    break;
                default:
                    lblStatement1.Location = new Point(lblStatement1.Location.X, lblStatement1.Location.Y + YCoordinateMovePerTick);
                    lblStatement2.Location = new Point(lblStatement2.Location.X, lblStatement2.Location.Y + YCoordinateMovePerTick);
                    lblStatement3.Location = new Point(lblStatement3.Location.X, lblStatement3.Location.Y + YCoordinateMovePerTick);
                    break;
            }
            checkIfMoveLabelToTop(lblStatement1);
            checkIfMoveLabelToTop(lblStatement2);
            checkIfMoveLabelToTop(lblStatement3);
        }

        private void transparentMountainBackground()
        {
            pbxBackground.Controls.Add(pbxMountains);
            pbxMountains.Location = new Point(0, 270);
            pbxMountains.BackColor = Color.Transparent;
        }

        private void transparentCloudBackgrounds()
        {
            pbxBackground.Controls.Add(pbxCloud2);
            pbxCloud2.Location = new Point(0, StatementYStartLocation);
            pbxCloud2.BackColor = Color.Transparent;
        }

        private void addLabelsToBackground()
        {
            pbxBackground.Controls.Add(lblStatement1);
            lblStatement1.Location = new Point(Statement1XPosition, StatementYStartLocation);

            pbxBackground.Controls.Add(lblStatement2);
            lblStatement2.Location = new Point(Statement2XPosition, StatementYStartLocation);

            pbxBackground.Controls.Add(lblStatement3);
            lblStatement3.Location = new Point(Statement3XPosition, StatementYStartLocation);
        }

        private void checkIfMoveLabelToTop(Label label)
        {
            if(label.Location.Y > StatementYEndLocation)
            {
                label.Location = new Point(label.Location.X, StatementYStartLocation);
                addStatementToLabel(label);
                clickedOrReachedBottomCount++;
                checkIfMoveToResults();
            }
        }

        private void addStatementToLabel(Label label)
        {
            if (currentStatement < statements.GetLength(0))
            {
                label.Text = statements[currentStatement, statementPosition];
                label.Tag = statements[currentStatement, isStatementTruePosition];
                currentStatement++;
            }

        }

        private void addStatementToAllLabels()
        {
            addStatementToLabel(lblStatement1);
            addStatementToLabel(lblStatement2);
            addStatementToLabel(lblStatement3);
        }

        private void LblStatement1_Click(object sender, EventArgs e)
        {
            labelClicked(lblStatement1);
        }

        private void LblStatement2_Click(object sender, EventArgs e)
        {
            labelClicked(lblStatement2);
        }

        private void LblStatement3_Click(object sender, EventArgs e)
        {
            labelClicked(lblStatement3);
        }

        private void labelClicked(Label label) {
            if (label.Tag.ToString() == trueStatement)
            {
                score++;
            }
            else
            {
                if(score > 0)
                {
                    score--;
                }
            }
            label.Location = new Point(label.Location.X, StatementYStartLocation);
            displayScore();
            clickedOrReachedBottomCount++;
            checkIfMoveToResults();
            addStatementToLabel(label);
        }

        private void displayScore()
        {
            lblScoreCount.Text = score.ToString();
        }

        private void disableAllButtons()
        {
            lblStatement1.Enabled = false;
            lblStatement2.Enabled = false;
            lblStatement3.Enabled = false;
            btnHelp.Enabled = false;
        }

        private void moveToResultsScreen()
        {
            this.Close();
            Form frm = new frmResults();
            frm.Show();
        }

        private void checkIfMoveToResults()
        {
            if (clickedOrReachedBottomCount == statements.GetLength(0))
            {
                moveToResultsScreen();
            }
        }

        private void LblSkipGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToResultsScreen();
        }
    }
}

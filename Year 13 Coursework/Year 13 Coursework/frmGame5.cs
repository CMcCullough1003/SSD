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
    public partial class frmGame5 : frmGame
    {

        private int counter = 30;
        private const string selected = "selected";
        private int selectedCount = 0;
        private int correctSelections = 0;
        private const int maximumSelectionsAllowed = 4;

        private string[] realSeas = new string[4];

        public frmGame5()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame5_Load(object sender, EventArgs e)
        {
            positionYacht();
            createRealSeaArray();
            setUpTimer();
            displayAvatar();
            setTitle();
            resetGame();

        }

        //The form is shown after frmMenu closes
        private void FrmGame5_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            displayCountdown();
            sinkYacht();
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

        private void LblSeaOfStorms_Click(object sender, EventArgs e)
        {
            seaClicked(lblSeaOfStorms);
        }

        private void LblPiSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblPiSea);
        }

        private void LblTiSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblTiSea);
        }

        private void LblSiSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblSiSea);
        }

        private void LblBrysSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblBrysSea);
        }

        private void LblSaltonSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblSaltonSea);
        }

        private void LblBrusselSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblBrusselSea);
        }

        private void LblArafuraSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblArafuraSea);
        }

        private void LblBoySea_Click(object sender, EventArgs e)
        {
            seaClicked(lblBoySea);
        }

        private void LblWeddellSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblWeddellSea);
        }

        private void LblBadSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblBadSea);
        }

        private void LblTasmanSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblTasmanSea);
        }

        private void LblOtisSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblOtisSea);
        }

        private void LblDylanSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblDylanSea);
        }

        private void LblSeaOfPlato_Click(object sender, EventArgs e)
        {
            seaClicked(lblSeaOfPlato);
        }

        private void LblEltonSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblEltonSea);
        }

        private void LblTempleSea_Click(object sender, EventArgs e)
        {
            seaClicked(lblTempleSea);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToMenuScreen();
        }

        private void BtnSubmitAnswer_Click(object sender, EventArgs e)
        {
            areAllSelectionsCorrect();
            lblCorrectGuessCount.Text = correctSelections + "/4";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        /* MY METHODS ======================================================================*/

        private void playGame()
        {
        }

        private void positionYacht() {
            pbxSky.Controls.Add(pbxYacht);
            pbxYacht.Location = new Point(75, 5);
            pbxYacht.BackColor = Color.Transparent;
        }

        private void sinkYacht()
        {
            pbxYacht.Location = new Point(pbxYacht.Location.X, pbxYacht.Location.Y + 2);
        }

        private void unsinkYacht()
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
                showCorrectAnswers();
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


        private void createRealSeaArray()
        {
            realSeas[0] = lblSaltonSea.Text;
            realSeas[1] = lblArafuraSea.Text;
            realSeas[2] = lblWeddellSea.Text;
            realSeas[3] = lblTasmanSea.Text;
        }

        private void seaClicked(Label label)
        {

            if (label.Tag.ToString() == selected)
            {
                label.Tag = "";
                label.BackColor = System.Drawing.Color.SteelBlue;
                selectedCount--;
            }
            else
            {
                if (selectedCount != maximumSelectionsAllowed)
                {
                    label.Tag = selected;
                    label.BackColor = System.Drawing.Color.DarkOrange;
                    selectedCount++;
                }
            }
            updateCorrectSelectionCount(label);
            updateSubmitButton();
        }

        private void resetGame()
        {
            selectedCount = 0;
            correctSelections = 0;
            updateSubmitButton();

            lblArafuraSea.Tag = "";
            lblBadSea.Tag = "";
            lblBoySea.Tag = "";
            lblBrusselSea.Tag = "";
            lblBrysSea.Tag = "";
            lblDylanSea.Tag = "";
            lblEltonSea.Tag = "";
            lblOtisSea.Tag = "";
            lblPiSea.Tag = "";
            lblSaltonSea.Tag = "";
            lblSeaOfPlato.Tag = "";
            lblSeaOfStorms.Tag = "";
            lblSiSea.Tag = "";
            lblTasmanSea.Tag = "";
            lblTempleSea.Tag = "";
            lblTiSea.Tag = "";
            lblWeddellSea.Tag = "";

            lblArafuraSea.BackColor = System.Drawing.Color.SteelBlue;
            lblBadSea.BackColor = System.Drawing.Color.SteelBlue;
            lblBoySea.BackColor = System.Drawing.Color.SteelBlue;
            lblBrusselSea.BackColor = System.Drawing.Color.SteelBlue;
            lblBrysSea.BackColor = System.Drawing.Color.SteelBlue;
            lblDylanSea.BackColor = System.Drawing.Color.SteelBlue;
            lblEltonSea.BackColor = System.Drawing.Color.SteelBlue;
            lblOtisSea.BackColor = System.Drawing.Color.SteelBlue;
            lblPiSea.BackColor = System.Drawing.Color.SteelBlue;
            lblSaltonSea.BackColor = System.Drawing.Color.SteelBlue;
            lblSeaOfPlato.BackColor = System.Drawing.Color.SteelBlue;
            lblSeaOfStorms.BackColor = System.Drawing.Color.SteelBlue;
            lblSiSea.BackColor = System.Drawing.Color.SteelBlue;
            lblTasmanSea.BackColor = System.Drawing.Color.SteelBlue;
            lblTempleSea.BackColor = System.Drawing.Color.SteelBlue;
            lblTiSea.BackColor = System.Drawing.Color.SteelBlue;
            lblWeddellSea.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void updateSubmitButton()
        {
            if (selectedCount == maximumSelectionsAllowed)
            {
                btnSubmitAnswer.Enabled = true;
                btnSubmitAnswer.BackColor = System.Drawing.Color.SaddleBrown;
            }
            else
            {
                btnSubmitAnswer.Enabled = false;
                btnSubmitAnswer.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void areAllSelectionsCorrect()
        {
            if (correctSelections == 4)
            {
                showCorrectAnswers();
            }
        }

        private void updateCorrectSelectionCount(Label selectedSea)
        {
            //Check to see if the chosen sea is a real sea
            int pos = Array.IndexOf(realSeas, selectedSea.Text);

            //If real the answer will be greater than -1
            if (pos >= 0)
            {
                //If the sea has been selected, increment
                //If the sea has been unselected, decrement
                if ( selectedSea.Tag.ToString() == selected)
                {
                    correctSelections++;
                }
                else
                {
                    correctSelections--;
                }
            }
        }

        private async void showCorrectAnswers()
        {
            lblSaltonSea.BackColor = System.Drawing.Color.Green;
            lblWeddellSea.BackColor = System.Drawing.Color.Green;
            lblArafuraSea.BackColor = System.Drawing.Color.Green;
            lblTasmanSea.BackColor = System.Drawing.Color.Green;
            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
            moveToMenuScreen();
        }
    }
}

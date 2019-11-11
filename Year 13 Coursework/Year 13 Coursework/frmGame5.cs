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
        private const int maximumSelectionsAllowed = 4;

        private string[] realSeas = new string[4];

        public frmGame5()
        {
            InitializeComponent();

        }

        //The form is created
        private void FrmGame5_Load(object sender, EventArgs e)
        {
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

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            resetGame();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
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

            if (label.Tag == selected)
            {
                label.Tag = "";
                label.BackColor = System.Drawing.Color.Red;
                selectedCount--;
            }
            else
            {
                if (selectedCount != maximumSelectionsAllowed)
                {
                    label.Tag = selected;
                    label.BackColor = System.Drawing.Color.Green;
                    selectedCount++;
                }
            }
            updateSubmitButton();
        }

        private void resetGame()
        {
            selectedCount = 0;
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

            lblArafuraSea.BackColor = System.Drawing.Color.Red;
            lblBadSea.BackColor = System.Drawing.Color.Red;
            lblBoySea.BackColor = System.Drawing.Color.Red;
            lblBrusselSea.BackColor = System.Drawing.Color.Red;
            lblBrysSea.BackColor = System.Drawing.Color.Red;
            lblDylanSea.BackColor = System.Drawing.Color.Red;
            lblEltonSea.BackColor = System.Drawing.Color.Red;
            lblOtisSea.BackColor = System.Drawing.Color.Red;
            lblPiSea.BackColor = System.Drawing.Color.Red;
            lblSaltonSea.BackColor = System.Drawing.Color.Red;
            lblSeaOfPlato.BackColor = System.Drawing.Color.Red;
            lblSeaOfStorms.BackColor = System.Drawing.Color.Red;
            lblSiSea.BackColor = System.Drawing.Color.Red;
            lblTasmanSea.BackColor = System.Drawing.Color.Red;
            lblTempleSea.BackColor = System.Drawing.Color.Red;
            lblTiSea.BackColor = System.Drawing.Color.Red;
            lblWeddellSea.BackColor = System.Drawing.Color.Red;
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
    }
}

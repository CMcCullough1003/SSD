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
    public partial class frmGame4 : frmGame
    {
        private int counter = 30;

        public frmGame4()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame4_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
        }

        //The form is shown after frmMenu closes
        private void FrmGame4_Activated(object sender, EventArgs e)
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


        private void LblA_Click(object sender, EventArgs e)
        {
            lblA.BackColor = System.Drawing.Color.Plum;
            lblA.ForeColor = System.Drawing.Color.Red;
            lblA.Enabled = false;
        }

        private void LblB_Click(object sender, EventArgs e)
        {

        }

        private void LblC_Click(object sender, EventArgs e)
        {

        }

        private void LblD_Click(object sender, EventArgs e)
        {

        }

        private void LblE_Click(object sender, EventArgs e)
        {

        }

        private void LblF_Click(object sender, EventArgs e)
        {

        }

        private void LblG_Click(object sender, EventArgs e)
        {

        }

        private void LblH_Click(object sender, EventArgs e)
        {

        }

        private void LblI_Click(object sender, EventArgs e)
        {

        }

        private void LblJ_Click(object sender, EventArgs e)
        {

        }

        private void LblK_Click(object sender, EventArgs e)
        {

        }

        private void LblL_Click(object sender, EventArgs e)
        {

        }

        private void LblM_Click(object sender, EventArgs e)
        {

        }

        private void LblN_Click(object sender, EventArgs e)
        {

        }

        private void LblO_Click(object sender, EventArgs e)
        {

        }

        private void LblP_Click(object sender, EventArgs e)
        {

        }

        private void LblQ_Click(object sender, EventArgs e)
        {

        }

        private void LblR_Click(object sender, EventArgs e)
        {

        }

        private void LblS_Click(object sender, EventArgs e)
        {

        }

        private void LblT_Click(object sender, EventArgs e)
        {

        }

        private void LblU_Click(object sender, EventArgs e)
        {

        }

        private void LblV_Click(object sender, EventArgs e)
        {

        }

        private void LblW_Click(object sender, EventArgs e)
        {

        }

        private void LblX_Click(object sender, EventArgs e)
        {

        }

        private void LblY_Click(object sender, EventArgs e)
        {

        }

        private void LblZ_Click(object sender, EventArgs e)
        {

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {

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
            timer1.Stop();
            moveToNextScreen();
        }
    }
}

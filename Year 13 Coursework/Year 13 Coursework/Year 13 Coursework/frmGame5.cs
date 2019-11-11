﻿using System;
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

        public frmGame5()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame5_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            playGame();
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

        }

        private void LblPiSea_Click(object sender, EventArgs e)
        {

        }

        private void LblTiSea_Click(object sender, EventArgs e)
        {

        }

        private void LblSiSea_Click(object sender, EventArgs e)
        {

        }

        private void LblBrysSea_Click(object sender, EventArgs e)
        {

        }

        private void LblSaltonSea_Click(object sender, EventArgs e)
        {

        }

        private void LblBrusselSea_Click(object sender, EventArgs e)
        {

        }

        private void LblArafuraSea_Click(object sender, EventArgs e)
        {

        }

        private void LblBoySea_Click(object sender, EventArgs e)
        {

        }

        private void LblWeddellSea_Click(object sender, EventArgs e)
        {

        }

        private void LblBadSea_Click(object sender, EventArgs e)
        {

        }

        private void LblTasmanSea_Click(object sender, EventArgs e)
        {

        }

        private void LblOtisSea_Click(object sender, EventArgs e)
        {

        }

        private void LblDylanSea_Click(object sender, EventArgs e)
        {

        }

        private void LblSeaOfPlato_Click(object sender, EventArgs e)
        {

        }

        private void LblEltonSea_Click(object sender, EventArgs e)
        {

        }

        private void LblTempleSea_Click(object sender, EventArgs e)
        {

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
    }
}
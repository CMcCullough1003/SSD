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
    public partial class frmGameMenu : Form
    {
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void FrmGameMenu_Load(object sender, EventArgs e)
        {
            fillLabels();
        }

        //MY METHODS ------------------------------------------------------------------------------------------

        private void fillLabels()
        {
            GameInfo gameInfo = new GameInfo();

            lblGameNumber.Text = gameInfo.gameNumber();
            lblGameTitle.Text = gameInfo.gameName();
            lblGameInfo.Text = gameInfo.gameDescription();
            lblGamePoints.Text = gameInfo.gamePoints();
        }

        //Keep screen in position above the game form to ensure it cannot be moved offscreen
        //Found on stackoverflow after googling
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

        //CLICK EVENTS ----------------------------------------------------------------------------------------

        private void BtnResumeGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

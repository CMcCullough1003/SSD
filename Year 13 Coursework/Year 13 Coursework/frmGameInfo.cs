using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_13_Coursework
{
    public partial class frmGameInfo : Form
    {
        public frmGameInfo()
        {
            InitializeComponent();
        }

        private void FrmGame1Info_Load(object sender, EventArgs e)
        {
            Program.currentGame++;
            switch (Program.currentGame)
            {
                case 1: game1Information(); break;
                case 2: game2Information(); break;
                case 3: game3Information(); break;
                case 4: game4Information(); break;
                case 5: game5Information(); break;
                case 6: game6Information(); break;
            }
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            switch (Program.currentGame)
            {
                case 1: moveToGame1(); break;
                case 2: moveToGame2(); break;
                case 3: moveToGame3(); break;
                case 4: moveToGame4(); break;
                case 5: moveToGame5(); break;
                case 6: moveToGame6(); break;
            }
        }

        private void game1Information()
        {
            lblGameNumber.Text = "Game 1";
            lblGameTitle.Text = "Game Title 1";
            lblGameInfo.Text = "1";
        }

        private void game2Information()
        {
            lblGameNumber.Text = "Game 2";
            lblGameTitle.Text = "Game Title 2";
            lblGameInfo.Text = "2";
        }

        private void game3Information()
        {
            lblGameNumber.Text = "Game 3";
            lblGameTitle.Text = "Game Title 3";
            lblGameInfo.Text = "3";
        }

        private void game4Information()
        {
            lblGameNumber.Text = "Game 4";
            lblGameTitle.Text = "Game Title 4";
            lblGameInfo.Text = "4";
        }

        private void game5Information()
        {
            lblGameNumber.Text = "Game 5";
            lblGameTitle.Text = "Game Title 5";
            lblGameInfo.Text = "5";
        }

        private void game6Information()
        {
            lblGameNumber.Text = "Game 6";
            lblGameTitle.Text = "Game Title 6";
            lblGameInfo.Text = "6";
        }

        private void moveToGame1()
        {
            this.Hide();
            Form MoveToGame1 = new frmGame1();
            MoveToGame1.Show();
        }

        private void moveToGame2()
        {
        }

        private void moveToGame3()
        {
        }

        private void moveToGame4()
        {
        }

        private void moveToGame5()
        {
        }

        private void moveToGame6()
        {
        }
    }
}

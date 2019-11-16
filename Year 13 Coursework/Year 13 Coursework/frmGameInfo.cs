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
    public partial class frmGameInfo : Form
    {
        public frmGameInfo()
        {
            InitializeComponent();
        }

        private void FrmGame1Info_Load(object sender, EventArgs e)
        {
            Program.currentGame++;
            fillLabels();
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

        private void fillLabels()
        {
            GameInfo gameInfo = new GameInfo();

            lblGameNumber.Text = gameInfo.gameNumber();
            lblGameTitle.Text = gameInfo.gameName();
            lblGameInfo.Text = gameInfo.gameDescription();
            lblGamePoints.Text = gameInfo.gamePoints();
        }

        private void moveToGame1()
        {
            this.Close();
            Form MoveToGame1 = new frmGame1();
            MoveToGame1.Show();
        }

        private void moveToGame2()
        {
            this.Close();
            Form MoveToGame2 = new frmGame2();
            MoveToGame2.Show();
        }

        private void moveToGame3()
        {
            this.Close();
            Form MoveToGame3 = new frmGame3();
            MoveToGame3.Show();
        }

        private void moveToGame4()
        {
            this.Close();
            Form MoveToGame4 = new frmGame4();
            MoveToGame4.Show();
        }

        private void moveToGame5()
        {
            this.Close();
            Form MoveToGame5 = new frmGame5();
            MoveToGame5.Show();
        }

        private void moveToGame6()
        {
            this.Close();
            Form MoveToGame6 = new frmGame6();
            MoveToGame6.Show();
        }
    }
}

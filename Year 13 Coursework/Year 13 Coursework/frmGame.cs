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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        public void moveToNextScreen()
        {
            this.Close();
            Form moveToNextScreen = new frmGameInfo();
            moveToNextScreen.Show();
        }

        public void saveScore(int score)
        {
            switch (Program.currentGame)
            {
                case 1: Program.currentUser.game1Score = score; break;
                case 2: Program.currentUser.game2Score = score; break;
                case 3: Program.currentUser.game3Score = score; break;
                case 4: Program.currentUser.game4Score = score; break;
                case 5: Program.currentUser.game5Score = score; break;
                case 6: Program.currentUser.game6Score = score; break;
            }

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }
    }
}

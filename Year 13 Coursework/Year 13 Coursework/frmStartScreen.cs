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
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            Form moveToGameInfo = new frmGameInfo();
            moveToGameInfo.Show();
        }

        private void moveToLoginScreen()
        {
            this.Close();
            Form moveToLogin = new frmLogin();
            moveToLogin.Show();
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            moveToLoginScreen();
        }

        private void FrmStartScreen_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            Program.currentGame = 0;

        }
    }
}

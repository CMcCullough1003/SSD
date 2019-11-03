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

        private void fillLabels()
        {
            GameInfo gameInfo = new GameInfo();

            lblGameNumber.Text = gameInfo.gameNumber();
            lblGameTitle.Text = gameInfo.gameName();
            lblGameInfo.Text = gameInfo.gameDescription();
        }

        private void BtnResumeGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

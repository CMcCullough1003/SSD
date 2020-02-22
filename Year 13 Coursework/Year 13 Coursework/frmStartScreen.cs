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
using Year_13_Coursework.Constants;

namespace Year_13_Coursework
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void FrmStartScreen_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + Program.currentUser.currentName;
            resetGame();
            displayPlayerScores();
        }

        //MY METHODS ------------------------------------------------------------------------------------------

        private void resetGame()
        {
            Program.currentGame = 0;
        }

        //Leaderboard
        private void addPlayerScoreRow(string player, string score)
        {
            ListViewItem row = new ListViewItem(player);
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, score));
            lsvLeaderboards.Items.Add(row);
        }

        private void displayPlayerScores()
        {
            Files files = new Files();
            List<string> userList = files.getFileContents(FileConstants.USER_FILE_NAME);

            foreach (string user in userList)
            {
                List<string> userDetails = user.Split(FileConstants.USER_FILE_SEPARATOR).ToList();
                string playerName = userDetails[FileConstants.USER_FILE_NAME_POSITION];
                string score = userDetails[FileConstants.USER_FILE_TOTAL_SCORE];
                addPlayerScoreRow(playerName, score);
            }
        }

        //CLICK EVENTS ----------------------------------------------------------------------------------------
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            moveToGameInfoScreen();
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            moveToLoginScreen();
        }

        //MOVE SCREENS ----------------------------------------------------------------------------------------

        private void moveToLoginScreen()
        {
            this.Close();
            Form moveToLogin = new frmLogin();
            moveToLogin.Show();
        }

        private void moveToGameInfoScreen()
        {
            this.Close();
            Form moveToGameInfo = new frmGameInfo();
            moveToGameInfo.Show();
        }
    }
}

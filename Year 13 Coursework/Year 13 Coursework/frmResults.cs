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
    public partial class frmResults : Form
    {
        private string grade = "";

        public frmResults()
        {
            InitializeComponent();
        }

        private void FrmResults_Load(object sender, EventArgs e)
        {
            displayScores();
            displayGrade();
        }

        private void displayScores() {
            label1.Text = Program.currentUser.game1Score.ToString() + "/6";
            label2.Text = Program.currentUser.game2Score.ToString() + "/3";
            label3.Text = Program.currentUser.game3Score.ToString() + "/9";
            label4.Text = Program.currentUser.game4Score.ToString() + "/6";
            label5.Text = Program.currentUser.game5Score.ToString() + "/4";
            label6.Text = Program.currentUser.game6Score.ToString() + "/16";
            lblTotal.Text = Program.currentUser.totalScore.ToString() + "/44";
        }

        private void displayGrade()
        {
            calculateGrade();
            lblGrade.Text = grade;
        }

        private void calculateGrade()
        {
            if(Program.currentUser.totalScore >= 35)
            {
                grade = "A";
            }
            else if (Program.currentUser.totalScore >= 29)
            {
                grade = "B";
            }
            else if (Program.currentUser.totalScore >= 23)
            {
                grade = "C";
            }
            else if (Program.currentUser.totalScore >= 17)
            {
                grade = "D";
            }
            else if (Program.currentUser.totalScore >= 11)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            moveToStartScreen();
            Program.currentUser.resetUserScores();
        }

        private void moveToStartScreen()
        {
            this.Close();
            Form frm = new frmStartScreen();
            frm.Show();
        }
    }
}

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
        public frmResults()
        {
            InitializeComponent();
        }

        private void FrmResults_Load(object sender, EventArgs e)
        {
            displayScores();
        }

        private void displayScores() {
            label1.Text = Program.currentUser.game1Score.ToString();
            label2.Text = Program.currentUser.game2Score.ToString();
            label3.Text = Program.currentUser.game3Score.ToString();
            label4.Text = Program.currentUser.game4Score.ToString();
            label5.Text = Program.currentUser.game5Score.ToString();
            label6.Text = Program.currentUser.game6Score.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DogCare
{
    public partial class frmFrontPage : Form
    {
        public frmFrontPage()
        {
            InitializeComponent();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            moveToTrainingForm();
        }

        public void moveToTrainingForm()
        {
            this.Hide();
            Form MoveToTrainingForm = new frmTraining();
            MoveToTrainingForm.Show();
        }

        public void errorMessage()
        {
            MessageBox.Show("This page is currently under construction. Come back later", "Unavailable");
        }

        private void btnDayCare_Click(object sender, EventArgs e)
        {
            errorMessage();
        }

        private void btnWalking_Click(object sender, EventArgs e)
        {
            errorMessage();
        }

        private void btngrooming_Click(object sender, EventArgs e)
        {
            errorMessage();
        }

        private void btnKennel_Click(object sender, EventArgs e)
        {
            errorMessage();
        }

        private void btnMobileGrooming_Click(object sender, EventArgs e)
        {
            errorMessage();
        }
    }
}

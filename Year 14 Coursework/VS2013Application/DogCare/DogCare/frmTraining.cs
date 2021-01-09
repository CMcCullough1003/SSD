using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCare
{
    public partial class frmTraining : Form
    {
        public frmTraining()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            moveToFrontPage();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            moveToFrmStaff();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            moveToFrmCustomer();
        }

        private void btnProgramType_Click(object sender, EventArgs e)
        {
        }

        private void btnProgramCost_Click(object sender, EventArgs e)
        {
            moveToFrmProgramVariety();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            moveToFrmDog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            moveToFrmClass();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            moveToFrmEnrollment();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            moveToFrmPayment();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            moveToFrmProgram();
        }

        //-----------------------------------------------------------------------------------------------------

        public void moveToFrontPage()
        {
            this.Hide();
            Form moveToFrontPage = new frmFrontPage();
            moveToFrontPage.Show();
        }

        public void moveToFrmStaff()
        {
            this.Hide();
            Form frmStaff = new frmStaff();
            frmStaff.Show();
        }

        public void moveToFrmCustomer()
        {
            this.Hide();
            Form frmCustomer = new frmClient();
            frmCustomer.Show();
        }

        public void moveToFrmProgramVariety()
        {
            this.Hide();
            Form frmProgramVariety = new frmProgramVariety();
            frmProgramVariety.Show();
        }

        public void moveToFrmDog()
        {
            this.Hide();
            Form frmDog = new frmDog();
            frmDog.Show();
        }

        public void moveToFrmClass()
        {
            this.Hide();
            Form frmClass = new frmClass();
            frmClass.Show();
        }

        public void moveToFrmEnrollment()
        {
            this.Hide();
            Form frmEnrollment = new frmEnrollment();
            frmEnrollment.Show();
        }

        public void moveToFrmPayment()
        {
            this.Hide();
            Form frmPayment = new frmPayment();
            frmPayment.Show();
        }

        public void moveToFrmProgram()
        {
            this.Hide();
            Form frmProgram = new frmProgram();
            frmProgram.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            moveToFrontPage();
        }
    }
}

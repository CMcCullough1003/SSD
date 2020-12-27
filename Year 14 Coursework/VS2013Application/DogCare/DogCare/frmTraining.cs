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
            moveToFrmProgramType();
        }

        private void btnProgramCost_Click(object sender, EventArgs e)
        {
            moveToFrmProgramCost();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            moveToFrmDog();
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

        public void moveToFrmProgramType()
        {
            this.Hide();
            Form frmProgramType = new frmProgramType();
            frmProgramType.Show();
        }

        public void moveToFrmProgramCost()
        {
            this.Hide();
            Form frmProgramCost = new frmProgramCosts();
            frmProgramCost.Show();
        }

        public void moveToFrmDog()
        {
            this.Hide();
            Form frmDog = new frmDog();
            frmDog.Show();
        }
    }
}

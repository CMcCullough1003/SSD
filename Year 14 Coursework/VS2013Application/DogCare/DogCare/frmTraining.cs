using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataStore;

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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            moveToFrontPage();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            moveToFrmReportSchedule();
        }

        private void btnOtstandingBalances_Click(object sender, EventArgs e)
        {
            moveToFrmReportBilling();
        }

        private void btnAvailableSpaces_Click(object sender, EventArgs e)
        {
            moveToFrmReportEnrollment();
        }

        private void btnIncompletePrograms_Click(object sender, EventArgs e)
        {
            moveToFrmReportProgram();
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

        public void moveToFrmReportSchedule()
        {
            this.Hide();
            Form frmReportSchedule = new frmReportSchedule();
            frmReportSchedule.Show();
        }

        public void moveToFrmReportBilling()
        {
            this.Hide();
            Form frmReportBilling = new frmReportBilling();
            frmReportBilling.Show();
        }

        public void moveToFrmReportEnrollment()
        {
            this.Hide();
            Form frmReportEnrollment = new frmReportEnrollment();
            frmReportEnrollment.Show();
        }

        public void moveToFrmReportProgram()
        {
            this.Hide();
            Form frmReportProgram = new frmReportProgram();
            frmReportProgram.Show();
        }

        private void frmTraining_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTraining_Activated(object sender, EventArgs e)
        {
            List<ReportScheduleModel> scheduleList = new Reports().readReportSchedule();
            if (scheduleList.Count > 0)
            {
                lblNextClass.Text = "The next class starts on " + scheduleList[0].classDate.ToString().Substring(0, 10) + " at " + scheduleList[0].startTime.ToString().Substring(0, 5);
            }
            else
            {
                lblNextClass.Text = "There are currently no classes scheduled";
            }

            List<ReportBillingModel> billingList = new Reports().readReportBilling();
            if (billingList.Count > 0)
            {
                lblOutstandingBalances.Text = "There are " + billingList.Count + " outstanding balances";
            }
            else
            {
                lblOutstandingBalances.Text = "There are no outstanding balances";
            }

            List<ReportEnrollmentModel> enrollmentList = new Reports().readReportEnrollment();
            if (billingList.Count > 0)
            {
                lblAvailableSpaces.Text = "There are " + enrollmentList.Count + " programs not fully booked";
            }
            else
            {
                lblAvailableSpaces.Text = "Are programs are fully booked";
            }

            List<ReportProgramModel> programList = new Reports().readReportProgram();
            if (billingList.Count > 0)
            {
                lblIncompletePrograms.Text = "There have been " + programList.Count + " programs created \nwithout the required number of classes";
            }
            else
            {
                lblIncompletePrograms.Text = "All programs have the required number of classes";
            }
        }
    }
}

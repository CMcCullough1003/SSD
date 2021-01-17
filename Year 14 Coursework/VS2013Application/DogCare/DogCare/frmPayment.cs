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
    public partial class frmPayment : Form
    {
        //Populated when an item on list is slected or when creating new record
        private PaymentModel selectedPayment = new PaymentModel();
        List<EnrollmentModel> enrollmentList = new List<EnrollmentModel>();

        private const string PLEASE_SELECT = "Please select";

        public frmPayment()
        {
            InitializeComponent();
            RefreshList();
        }


        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvPayment.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<PaymentModel> paymentList = new PaymentTable().readAll();
            List<EnrollmentModel> enrollmentList = new EnrollmentTable().readAll();


            //loop through all the records
            foreach (var payment in paymentList)
            {
                var enrollmentIndex = new ForeignKeyHelper().findIndexOfEnrollmentID(enrollmentList, payment.enrollmentId);
                var enrollmentName = enrollmentList[enrollmentIndex].name;
                //create an array that will hold all the fields in a row
                var row = new string[] { payment.id.ToString(), enrollmentName, payment.paymentAmountDue.ToString(), payment.paymentType, payment.paymentAmountDueDate.ToString(), payment.paymentRecieved.ToString(), payment.paymentRecievedDate.ToString(), payment.recieptIssued.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = payment;

                //add new row to the ListView
                lsvPayment.Items.Add(lvi);
            }
            lsvPayment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedPayment.id == 0)
            {
                return;
            }

            //fill up the input fields
            lblIDReadOnly.Text = selectedPayment.id.ToString();
            lblPaymentReadOnly.Text = selectedPayment.paymentAmountDue.ToString();
            lblPaymentTypeReadOnly.Text = selectedPayment.paymentType;
            lblDueDateReadOnly.Text = selectedPayment.paymentAmountDueDate.ToString();
            if (rbtnPaymentRecievedYes.Checked)
            {
                selectedPayment.paymentRecieved = true;
            }
            if (rbtnPaymentRecievedNo.Checked)
            {
                selectedPayment.paymentRecieved = false;
            }
            txtPaymentRecievedDate.Text = selectedPayment.paymentRecievedDate.ToString();
            if (rbtnRecieptIssuedYes.Checked)
            {
                selectedPayment.recieptIssued = true;
            }
            if (rbtnRecieptIssuedNo.Checked)
            {
                selectedPayment.recieptIssued = false;
            }
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            lblEnrollmentReadOnly.Text = "";
            lblPaymentReadOnly.Text = "";
            lblPaymentTypeReadOnly.Text = "";
            lblDueDateReadOnly.Text = "";
            rbtnPaymentRecievedYes.Checked = false;
            rbtnPaymentRecievedNo.Checked = false;
            txtPaymentRecievedDate.Text = "";
            rbtnRecieptIssuedYes.Checked = false;
            rbtnRecieptIssuedNo.Checked = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedPayment = new PaymentModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (new InputCheckMessageBox().checkInputIsDateTime(txtPaymentRecievedDate.Text, lblPaymentRecievedDate.Text) == false)
            {
                return;
            }

            try
            {
                if (rbtnPaymentRecievedYes.Checked)
                {
                    selectedPayment.paymentRecieved = true;
                }
                if (rbtnPaymentRecievedNo.Checked)
                {
                    selectedPayment.paymentRecieved = false;
                }
                selectedPayment.paymentRecievedDate = Convert.ToDateTime(txtPaymentRecievedDate.Text);
                if (rbtnRecieptIssuedYes.Checked)
                {
                    selectedPayment.recieptIssued = true;
                }
                if (rbtnRecieptIssuedNo.Checked)
                {
                    selectedPayment.recieptIssued = false;
                }


                //The id will be 0 if New button was clicked
                if (selectedPayment.id == 0)
                {
                    MessageBox.Show("Payment records are created automatically when you enroll", "Payment not created");
                }
                else
                {
                    new PaymentTable().update(selectedPayment);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedPayment = new PaymentModel();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedPayment.id == 0)
            {
                return;
            }

            //Don't let them delete it by accident
            DialogResult result = MessageBox.Show(
                "Sorry, you need to contact the administrator to delete payments",
                "Important Announcement");
        }

        private void lsvPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedPayment = (PaymentModel)lsvPayment.SelectedItems[0].Tag;

                //fill the input fields
                PopulateInputs();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            moveToTrainingForm();
        }

        public void moveToTrainingForm()
        {
            Form MoveToTrainingForm = new frmTraining();
            MoveToTrainingForm.Show();
            this.Close();
        }
    }
}

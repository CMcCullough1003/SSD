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
            fetchEnrollments();
            RefreshList();
        }

        private void fetchEnrollments()
        {
            enrollmentList = new EnrollmentTable().readAll();

            cbxEnrollment.DisplayMember = "Text";
            cbxEnrollment.ValueMember = "Value";

            foreach (var enrollment in enrollmentList)
            {
                cbxEnrollment.Items.Add(new { Text = enrollment.name, Value = enrollment.id });
            }
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvPayment.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<PaymentModel> paymentList = new PaymentTable().readAll();

            //loop through all the records
            foreach (var payment in paymentList)
            {
                var enrollmentIndex = new ForeignKeyHelper().findIndexOfEnrollmentID(enrollmentList, payment.enrollmentId);
                var enrollmentName = enrollmentList[enrollmentIndex].name;
                //create an array that will hold all the fields in a row
                var row = new string[] { payment.id.ToString(), enrollmentName, payment.paymentAmountDue.ToString(), payment.paymentAmountDueDate.ToString(), payment.paymentRecieved.ToString(), payment.paymentRecievedDate.ToString(), payment.recieptIssued.ToString() };
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

            cbxEnrollment.Text = PLEASE_SELECT;
            cbxEnrollment.SelectedIndex = -1;
            cbxEnrollment.SelectedIndex = new ForeignKeyHelper().findIndexOfEnrollmentID(enrollmentList, selectedPayment.enrollmentId);

            //fill up the input fields
            lblIDReadOnly.Text = selectedPayment.id.ToString();
            txtPayment.Text = selectedPayment.paymentAmountDue.ToString();
            txtDueDate.Text = selectedPayment.paymentAmountDueDate.ToString();
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
            cbxEnrollment.Text = PLEASE_SELECT;
            txtPayment.Text = "";
            txtDueDate.Text = "";
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
            if (cbxEnrollment.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select an enrollment", "Missing input");
                return;
            }

            if (new InputCheckMessageBox().checkInputIsDouble(txtPayment.Text, lblPayment.Text) == false)
            {
                return;
            }

            if (new InputCheckMessageBox().checkInputIsDateTime(txtDueDate.Text, lblDueDate.Text) == false)
            {
                return;
            }

            if (new InputCheckMessageBox().checkInputIsDateTime(txtPaymentRecievedDate.Text, lblPaymentRecievedDate.Text) == false)
            {
                return;
            }

            try
            {
                //fill up the model with all the input fields
                selectedPayment.enrollmentId = (cbxEnrollment.SelectedItem as dynamic).Value;
                //Convert.ToInt32(cbxEnrollment.SelectedItem);
                selectedPayment.paymentAmountDue = Convert.ToDouble(txtPayment.Text);
                selectedPayment.paymentAmountDueDate = Convert.ToDateTime(txtDueDate.Text);
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
                    new PaymentTable().create(selectedPayment);
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
                "Wow!! Wait...are you sure?",
                "Important Question",
                MessageBoxButtons.YesNo);

            //Abort!!
            if (result == DialogResult.No)
            {
                return;
            }

            //Delete the reord from the table and update the ListView
            try
            {
                new PaymentTable().delete(selectedPayment.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedPayment = new PaymentModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
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
    }
}

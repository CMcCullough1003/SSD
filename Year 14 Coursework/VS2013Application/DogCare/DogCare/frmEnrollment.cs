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
    public partial class frmEnrollment : Form
    {
        //Populated when an item on list is slected or when creating new record
        private EnrollmentModel selectedEnrollment = new EnrollmentModel();
        List<ProgramModel> programList = new List<ProgramModel>();
        List<ClientModel> clientList = new List<ClientModel>();
        List<DogModel> dogList = new List<DogModel>();
        List<ProgramVarietyModel> programVarietyList = new List<ProgramVarietyModel>();

        private const string PLEASE_SELECT = "Please select";

        public frmEnrollment()
        {
            InitializeComponent();
            fetchPrograms();
            fetchClients();
            fetchDogs();
            fetchProgramVarieties();
            RefreshList();
        }

        private void fetchPrograms()
        {
            programList = new ProgramTable().readAll();

            cbxProgram.DisplayMember = "Text";
            cbxProgram.ValueMember = "Value";

            foreach (var program in programList)
            {
                cbxProgram.Items.Add(new { Text = program.name, Value = program.id });
            }
        }

        private void fetchClients()
        {
            clientList = new ClientTable().readAll();

            cbxClient.DisplayMember = "Text";
            cbxClient.ValueMember = "Value";

            foreach (var client in clientList)
            {
                cbxClient.Items.Add(new { Text = client.displayName, Value = client.id });
            }
        }
        
        private void fetchDogs()
        {
            dogList = new DogTable().readAll();

            cbxDog.DisplayMember = "Text";
            cbxDog.ValueMember = "Value";

            foreach (var dog in dogList)
            {
                var clientIndex = new ForeignKeyHelper().findIndexOfClientID(clientList, dog.clientID);
                cbxDog.Items.Add(new { Text = dog.name + " (owned by " + clientList[clientIndex].displayName + ")", Value = dog.id });
            }
        }

        private void fetchProgramVarieties()
        {
            programVarietyList = new ProgramVarietyTable().readAll();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvEnrollment.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<EnrollmentModel> enrollmentList = new EnrollmentTable().readAll();

            //loop through all the records
            foreach (var enrollment in enrollmentList)
            {
                var programIndex = new ForeignKeyHelper().findIndexOfProgramID(programList, enrollment.programId);
                var programDescription = programList[programIndex].name;

                var clientIndex = new ForeignKeyHelper().findIndexOfClientID(clientList, enrollment.clientId);
                var clientName = clientList[clientIndex].displayName;

                var dogIndex = new ForeignKeyHelper().findIndexOfDogID(dogList, enrollment.dogId);
                var dogName = dogList[dogIndex].name;

                var paymentMethodDescription = new PaymentConstants().fetchPaymentMethod(enrollment.paymentMethod);

                //create an array that will hold all the fields in a row
                var row = new string[] { enrollment.id.ToString(), enrollment.name, clientName, dogName, programDescription, paymentMethodDescription, enrollment.joinDate.ToString(), enrollment.inviteIssued.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = enrollment;

                //add new row to the ListView
                lsvEnrollment.Items.Add(lvi);
            }
            lsvEnrollment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedEnrollment.id == 0)
            {
                return;
            }

            cbxProgram.Text = PLEASE_SELECT;
            cbxProgram.SelectedIndex = -1;
            cbxProgram.SelectedIndex = new ForeignKeyHelper().findIndexOfProgramID(programList, selectedEnrollment.programId);

            cbxClient.Text = PLEASE_SELECT;
            cbxClient.SelectedIndex = -1;
            cbxClient.SelectedIndex = new ForeignKeyHelper().findIndexOfClientID(clientList, selectedEnrollment.clientId);

            cbxDog.Text = PLEASE_SELECT;
            cbxDog.SelectedIndex = -1;
            cbxDog.SelectedIndex = new ForeignKeyHelper().findIndexOfDogID(dogList, selectedEnrollment.dogId);

            //fill up the input fields
            lblIDReadOnly.Text = selectedEnrollment.id.ToString();
            lblNameReadOnly.Text = cbxDog.Text + " in " + cbxProgram.Text;
            if ( selectedEnrollment.paymentMethod == PaymentConstants.PAYMENT_IN_FULL )
            {
                rbtnPayInFull.Checked = true;
            }
            if (selectedEnrollment.paymentMethod == PaymentConstants.PAYMENT_PER_CLASS)
            {
                rbtnPayPerClass.Checked = true;
            }
            lblJoinDateReadOnly.Text = selectedEnrollment.joinDate.ToString();

            if (selectedEnrollment.inviteIssued == true)
            {
                rbtnInviteIssuedYes.Checked = true;
            }
            if (selectedEnrollment.inviteIssued == false)
            {
                rbtnInviteIssuedNo.Checked = true;
            }

            disableInputs();
        }

        private void disableInputs()
        {
            enableInputs();

            if (selectedEnrollment.id == 0)
            {
                return;
            }

            cbxProgram.Enabled = false;
            cbxClient.Enabled = false;
            cbxDog.Enabled = false;
            rbtnPayInFull.Enabled = false;
            rbtnPayPerClass.Enabled = false;

            if (rbtnInviteIssuedYes.Checked == true)
            {
                rbtnInviteIssuedYes.Enabled = false;
                rbtnInviteIssuedNo.Enabled = false;
            }
        }

        private void enableInputs()
        {
            cbxProgram.Enabled = true;
            cbxClient.Enabled = true;
            cbxDog.Enabled = true;
            rbtnPayInFull.Enabled = true;
            rbtnPayPerClass.Enabled = true;
            rbtnInviteIssuedYes.Enabled = true;
            rbtnInviteIssuedNo.Enabled = true;
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            lblNameReadOnly.Text = "";
            cbxProgram.Text = PLEASE_SELECT;
            cbxClient.Text = PLEASE_SELECT;
            cbxDog.Text = PLEASE_SELECT;
            rbtnPayInFull.Checked = false;
            rbtnPayPerClass.Checked = false;
            lblJoinDateReadOnly.Text = "";
            rbtnInviteIssuedYes.Checked = false;
            rbtnInviteIssuedNo.Checked = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedEnrollment = new EnrollmentModel();
            enableInputs();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedEnrollment.id != 0 && selectedEnrollment.inviteIssued == true) 
            {
                MessageBox.Show("Sorry, this record cannot be updated.\n\nPlease delete this enrollment record and create a new one.", "Cannot update record");
                return;
            }

            if (cbxProgram.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a program", "Missing input");
                return;
            }

            if (cbxClient.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a client", "Missing input");
                return;
            }

            if (cbxDog.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a dog", "Missing input");
                return;
            }

            if (rbtnPayInFull.Checked == false && rbtnPayPerClass.Checked == false)
            {
                MessageBox.Show("Please select a payment method", "Missing input");
                return;
            }

            if (rbtnInviteIssuedNo.Checked == false && rbtnInviteIssuedYes.Checked == false)
            {
                MessageBox.Show("Please select a payment method", "Missing input");
                return;
            }

            try
            {
                //fill up the model with all the input fields
                selectedEnrollment.name = cbxDog.Text + " in " + cbxProgram.Text;
                selectedEnrollment.programId = (cbxProgram.SelectedItem as dynamic).Value;
                selectedEnrollment.clientId = (cbxClient.SelectedItem as dynamic).Value;
                selectedEnrollment.dogId = (cbxDog.SelectedItem as dynamic).Value;
                if (rbtnPayInFull.Checked)
                {
                    selectedEnrollment.paymentMethod = 1;
                }
                if (rbtnPayPerClass.Checked)
                {
                    selectedEnrollment.paymentMethod = 2;
                }
                selectedEnrollment.joinDate = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                if (rbtnInviteIssuedYes.Checked)
                {
                    selectedEnrollment.inviteIssued = true;
                }
                if (rbtnInviteIssuedNo.Checked)
                {
                    selectedEnrollment.inviteIssued = false;
                }


                var dogIndex = new ForeignKeyHelper().findIndexOfDogID(dogList, selectedEnrollment.dogId);
                var clientIndex = new ForeignKeyHelper().findIndexOfClientID(clientList, dogList[dogIndex].clientID);
                if (dogList[dogIndex].clientID != selectedEnrollment.clientId)
                {
                    string message = ("Sorry, " + dogList[dogIndex].name + " belongs to " + clientList[clientIndex].displayName);
                    MessageBox.Show(message, "dog mixup");
                    return;
                }

                //The id will be 0 if New button was clicked


                if (selectedEnrollment.id == 0)
                {
                    var enrollmentId = new EnrollmentTable().create(selectedEnrollment);
                    selectedEnrollment.id = enrollmentId;
                    MessageBox.Show("Payment is now due.\n\nPlease process payment on the payment screen.", "Payment due");
                }
                else
                {
                    new EnrollmentTable().update(selectedEnrollment);
                }

                createPayments();

                //reset everything
                enableInputs();
                ClearInputs();
                RefreshList();
                selectedEnrollment = new EnrollmentModel();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void createPayments()
        {
            var programVarietyModel = fetchVariety();
            createPaymentDeposit(programVarietyModel);

            if (rbtnPayInFull.Checked == true && rbtnInviteIssuedYes.Checked == true)
            {
                createPaymentBalance(programVarietyModel);
                return;
            }

            if (selectedEnrollment.id == 0 && rbtnPayPerClass.Checked == true && rbtnInviteIssuedYes.Checked == true)
            {
                createPaymentInstallments(programVarietyModel);
                return;
            }

            if (selectedEnrollment.id != 0 && selectedEnrollment.inviteIssued == false && rbtnInviteIssuedYes.Checked == true)
            {
                createPaymentInstallments(programVarietyModel);
                return;
            }
        }

        public void createPaymentDeposit(ProgramVarietyModel programVarietyModel)
        {
            var paymentModel = new PaymentModel();
            paymentModel.enrollmentId = selectedEnrollment.id;
            paymentModel.paymentAmountDue = programVarietyModel.depositAmount;
            paymentModel.paymentAmountDueDate = DateTime.Now;
            paymentModel.paymentRecieved = false;
            paymentModel.paymentType = PaymentTypeConstants.DEPOSIT;
            paymentModel.recieptIssued = false;
            PaymentTable paymentTable = new PaymentTable();
            paymentTable.create(paymentModel);
        }

        public void createPaymentBalance(ProgramVarietyModel programVarietyModel)
        {
            var totalCostOfClasses = programVarietyModel.noOfClasses * programVarietyModel.sessionCost;
            var discountAmount = totalCostOfClasses / 100 * programVarietyModel.fullPaymentPercentageDiscount;
            var balance = totalCostOfClasses - discountAmount - programVarietyModel.depositAmount;
            var paymentModel = new PaymentModel();
            paymentModel.enrollmentId = selectedEnrollment.id;
            paymentModel.paymentAmountDue = balance;
            paymentModel.paymentAmountDueDate = DateTime.Now;
            paymentModel.paymentRecieved = false;
            paymentModel.paymentType = PaymentTypeConstants.BALANCE;
            paymentModel.recieptIssued = false;
            PaymentTable paymentTable = new PaymentTable();
            paymentTable.create(paymentModel);
        }

        public void createPaymentInstallments(ProgramVarietyModel programVarietyModel)
        {
            var totalCostOfClasses = programVarietyModel.noOfClasses * programVarietyModel.sessionCost;
            var numberOfInstallments = programVarietyModel.noOfClasses / 2;
            var installmentAmountTotal = totalCostOfClasses - programVarietyModel.depositAmount;
            var installmentAmount = Math.Round(installmentAmountTotal / numberOfInstallments, 2);

            for (int i = 1; i <= numberOfInstallments; i++)
            {
                var paymentModel = new PaymentModel();
                paymentModel.enrollmentId = selectedEnrollment.id;
                paymentModel.paymentAmountDue = installmentAmount;
                paymentModel.paymentAmountDueDate = DateTime.Now.AddDays(i * 14);
                paymentModel.paymentRecieved = false;
                paymentModel.paymentType = PaymentTypeConstants.INSTALLMENT;
                paymentModel.recieptIssued = false;
                PaymentTable paymentTable = new PaymentTable();
                paymentTable.create(paymentModel);
            }
        }

        private ProgramVarietyModel fetchVariety()
        {
            foreach (var program in programList)
            {
                if (program.id == selectedEnrollment.programId)
                {
                    foreach (var variety in programVarietyList)
                    {
                        if (program.programVarietyId == variety.id)
                        {
                            return variety;
                        }
                    }
                }
            }
            return new ProgramVarietyModel();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedEnrollment.id == 0)
            {
                return;
            }

            //Don't let them delete it by accident
            DialogResult result = MessageBox.Show(
                "Wow!! Wait...are you sure?\n\nNote: All future payment records associated with this enrollment will be deleted",
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
                new EnrollmentTable().delete(selectedEnrollment.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedEnrollment = new EnrollmentModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvEnrollment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedEnrollment = (EnrollmentModel)lsvEnrollment.SelectedItems[0].Tag;

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

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
    public partial class frmProgramVariety : Form
    {
        //Populated when an item on list is slected or when creating new record
        private ProgramVarietyModel selectedProgramVariety = new ProgramVarietyModel();
        private const string PLEASE_SELECT = "Please select";

        public frmProgramVariety()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvProgramVariety.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ProgramVarietyModel> programVarietyList = new ProgramVarietyTable().readAll();

            //loop through all the records
            foreach (var programVariety in programVarietyList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { programVariety.id.ToString(), programVariety.name, programVariety.depositAmount.ToString(), programVariety.sessionCost.ToString(), programVariety.fullPaymentPercentageDiscount.ToString(), programVariety.dogSpacesMaximum.ToString(), programVariety.noOfClasses.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = programVariety;

                //add new row to the ListView
                lsvProgramVariety.Items.Add(lvi);
            }
            lsvProgramVariety.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedProgramVariety.id == 0)
            {
                return;
            }

            //fill up the input fields
            lblIDReadOnly.Text = selectedProgramVariety.id.ToString();
            if (selectedProgramVariety.name == ProgramVarietyConstants.REGULAR)
            {
                rbtnRegular.Checked = true;
            }
            if (selectedProgramVariety.name== ProgramVarietyConstants.ADVANCED)
            {
                rbtnAdvanced.Checked = true;
            }
            txtDepositAmount.Text = selectedProgramVariety.depositAmount.ToString();
            txtSessionCost.Text = selectedProgramVariety.sessionCost.ToString();
            txtPercentageDiscount.Text = selectedProgramVariety.fullPaymentPercentageDiscount.ToString();
            txtMaximumNumberOfDogs.Text = selectedProgramVariety.dogSpacesMaximum.ToString();
            txtNumberOfClasses.Text = selectedProgramVariety.noOfClasses.ToString();

        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            rbtnRegular.Checked = false;
            rbtnAdvanced.Checked = false;
            txtDepositAmount.Text = "";
            txtSessionCost.Text = "";
            txtPercentageDiscount.Text = "";
            txtNumberOfClasses.Text = "";
            txtMaximumNumberOfDogs.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedProgramVariety = new ProgramVarietyModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InputCheckMessageBox inputCheckMessageBox = new InputCheckMessageBox();

            if (rbtnRegular.Checked == false && rbtnAdvanced.Checked == false)
            {
                MessageBox.Show("Please select a variety", "Missing input");
                return;
            }

            if (inputCheckMessageBox.checkInputIsDouble(txtDepositAmount.Text, lblDepositAmount.Text) == false)
            {
                return;
            }

            if (inputCheckMessageBox.checkInputIsDouble(txtSessionCost.Text, lblSessionCost.Text) == false)
            {
                return;
            }

            if (inputCheckMessageBox.checkInputIsDouble(txtPercentageDiscount.Text, lblPercentageDiscount.Text) == false)
            {
                return;
            }

            if (inputCheckMessageBox.checkInputIsDouble( txtMaximumNumberOfDogs.Text, lblMaximumNumberOfDogs.Text ) == false)
            {
                return;
            }

            if (inputCheckMessageBox.checkInputIsDouble(txtNumberOfClasses.Text, lblNumberOfClasses.Text) == false)
            {
                return;
            }


            try
            {
                //fill up the model with all the input fields 
                if (rbtnRegular.Checked)
                {
                    selectedProgramVariety.name = ProgramVarietyConstants.REGULAR;
                }
                if (rbtnAdvanced.Checked)
                {
                    selectedProgramVariety.name = ProgramVarietyConstants.ADVANCED;
                }
                selectedProgramVariety.depositAmount = Convert.ToDouble(txtDepositAmount.Text);
                selectedProgramVariety.sessionCost = Convert.ToDouble(txtSessionCost.Text);
                selectedProgramVariety.fullPaymentPercentageDiscount = Convert.ToDouble(txtPercentageDiscount.Text);
                selectedProgramVariety.dogSpacesMaximum = Convert.ToInt32( txtMaximumNumberOfDogs.Text );
                selectedProgramVariety.noOfClasses = Convert.ToInt32(txtNumberOfClasses.Text);

                //The id will be 0 if New button was clicked
                if (selectedProgramVariety.id == 0)
                {
                    new ProgramVarietyTable().create(selectedProgramVariety);
                }
                else
                {
                    new ProgramVarietyTable().update(selectedProgramVariety);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramVariety = new ProgramVarietyModel();
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
            if (selectedProgramVariety.id == 0)
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
                new ProgramVarietyTable().delete(selectedProgramVariety.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramVariety = new ProgramVarietyModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvProgramCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedProgramVariety = (ProgramVarietyModel)lsvProgramVariety.SelectedItems[0].Tag;

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
            this.Hide();
            Form MoveToTrainingForm = new frmTraining();
            MoveToTrainingForm.Show();
        }
    }
}

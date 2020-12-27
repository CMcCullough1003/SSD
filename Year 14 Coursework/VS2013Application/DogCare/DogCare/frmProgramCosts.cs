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
    public partial class frmProgramCosts : Form
    {
        //Populated when an item on list is slected or when creating new record
        private ProgramCostModel selectedProgramCost = new ProgramCostModel();

        public frmProgramCosts()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvProgramCost.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ProgramCostModel> programCost = new ProgramCostTable().readAll();

            //loop through all the records
            foreach (var person in programCost)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { person.id.ToString(), person.offerName, person.depositAmount.ToString(), person.sessionCost.ToString(), person.fullPaymentPercentageDiscount.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = person;

                //add new row to the ListView
                lsvProgramCost.Items.Add(lvi);
            }
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedProgramCost.id == 0)
            {
                return;
            }

            //fill up the input fields
            lblIDReadOnly.Text = selectedProgramCost.id.ToString();
            txtOffer.Text = selectedProgramCost.offerName;
            txtDepositAmount.Text = selectedProgramCost.depositAmount.ToString();
            txtSessionCost.Text = selectedProgramCost.sessionCost.ToString();
            txtPercentageDiscount.Text = selectedProgramCost.depositAmount.ToString();
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            txtOffer.Text = "";
            txtDepositAmount.Text = "";
            txtSessionCost.Text = "";
            txtPercentageDiscount.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedProgramCost = new ProgramCostModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InputCheckMessageBox inputCheckMessageBox = new InputCheckMessageBox();

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

            try
            {
                //fill up the model with all the input fields 
                selectedProgramCost.offerName = txtOffer.Text;
                selectedProgramCost.depositAmount = Convert.ToDouble(txtDepositAmount.Text);
                selectedProgramCost.sessionCost = Convert.ToDouble(txtSessionCost.Text);
                selectedProgramCost.fullPaymentPercentageDiscount = Convert.ToDouble(txtPercentageDiscount.Text);

                //The id will be 0 if New button was clicked
                if (selectedProgramCost.id == 0)
                {
                    new ProgramCostTable().create(selectedProgramCost);
                }
                else
                {
                    new ProgramCostTable().update(selectedProgramCost);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramCost = new ProgramCostModel();
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
            if (selectedProgramCost.id == 0)
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
                new ProgramCostTable().delete(selectedProgramCost.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramCost = new ProgramCostModel();
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
                selectedProgramCost = (ProgramCostModel)lsvProgramCost.SelectedItems[0].Tag;

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

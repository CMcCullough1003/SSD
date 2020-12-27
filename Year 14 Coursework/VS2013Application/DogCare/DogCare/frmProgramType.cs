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
    public partial class frmProgramType : Form
    {
        //Populated when an item on list is slected or when creating new record
        private ProgramTypeModel selectedProgramType = new ProgramTypeModel();

        public frmProgramType()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvProgramType.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ProgramTypeModel> programType = new ProgramTypeTable().readAll();

            //loop through all the records
            foreach (var person in programType)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { person.id.ToString(), person.description };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = person;

                //add new row to the ListView
                lsvProgramType.Items.Add(lvi);
            }
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedProgramType.id == 0)
            {
                return;
            }

            //fill up the input fields
            lblIDReadOnly.Text = selectedProgramType.id.ToString();
            txtDescription.Text = selectedProgramType.description;
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            txtDescription.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedProgramType.id == 0)
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
                new ProgramTypeTable().delete(selectedProgramType.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramType = new ProgramTypeModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //fill up the model with all the input fields 
                selectedProgramType.description = txtDescription.Text;

                //The id will be 0 if New button was clicked
                if (selectedProgramType.id == 0)
                {
                    new ProgramTypeTable().create(selectedProgramType);
                }
                else
                {
                    new ProgramTypeTable().update(selectedProgramType);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgramType = new ProgramTypeModel();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedProgramType = new ProgramTypeModel();
            ClearInputs();
        }

        private void lsvProgramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedProgramType = (ProgramTypeModel)lsvProgramType.SelectedItems[0].Tag;

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

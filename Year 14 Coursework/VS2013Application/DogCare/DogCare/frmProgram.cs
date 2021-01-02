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
    public partial class frmProgram : Form
    {
        //Populated when an item on list is slected or when creating new record
        private ProgramModel selectedProgram = new ProgramModel();
        List<ProgramVarietyModel> programVarietyList = new List<ProgramVarietyModel>();
        private const string PLEASE_SELECT = "Please select";

        public frmProgram()
        {
            InitializeComponent();
            fetchProgramVarieties();
            RefreshList();
        }


        private void fetchProgramVarieties()
        {
            programVarietyList = new ProgramVarietyTable().readAll();

            cbxProgramVariety.DisplayMember = "Text";
            cbxProgramVariety.ValueMember = "Value";

            foreach (var programCost in programVarietyList)
            {
                cbxProgramVariety.Items.Add(new { Text = programCost.name, Value = programCost.id });
            }
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvProgram.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ProgramModel> programs = new ProgramTable().readAll();

            //loop through all the records
            foreach (var program in programs)
            {

                var programVarietyIndex = new ForeignKeyHelper().findIndexOfProgramVarietyID(programVarietyList, program.programVarietyId);
                var programVarietyName = programVarietyList[programVarietyIndex].name;

                //create an array that will hold all the fields in a row
                var row = new string[] { program.id.ToString(), programVarietyName, program.dogSpacesMaximum.ToString(), program.noOfClasses.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = program;

                //add new row to the ListView
                lsvProgram.Items.Add(lvi);
            }
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedProgram.id == 0)
            {
                return;
            }

            cbxProgramVariety.Text = PLEASE_SELECT;
            cbxProgramVariety.SelectedIndex = -1;
            cbxProgramVariety.SelectedIndex = new ForeignKeyHelper().findIndexOfProgramVarietyID(programVarietyList, selectedProgram.programVarietyId);

            //fill up the input fields
            lblIDReadOnly.Text = selectedProgram.id.ToString();
            txtMaximumSpaces.Text = selectedProgram.dogSpacesMaximum.ToString();
            txtNumberOfClasses.Text = selectedProgram.noOfClasses.ToString();
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            lblNameReadOnly.Text = "";
            cbxProgramVariety.Text = PLEASE_SELECT;
            txtMaximumSpaces.Text = "";
            txtNumberOfClasses.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedProgram = new ProgramModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbxProgramVariety.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a program variety", "Missing input");
                return;
            }

            if (new InputCheckMessageBox().checkInputIsInt(txtMaximumSpaces.Text, lblMaximumSpaces.Text) == false)
            {
                return;
            }

            if (new InputCheckMessageBox().checkInputIsInt(txtNumberOfClasses.Text, lblNumberOfClasses.Text) == false)
            {
                return;
            }

            try
            {
                //fill up the model with all the input fields
                selectedProgram.programVarietyId = (cbxProgramVariety.SelectedItem as dynamic).Value;
                selectedProgram.name = lblNameReadOnly.Text;
                selectedProgram.dogSpacesMaximum = Convert.ToInt32(txtMaximumSpaces.Text);
                selectedProgram.noOfClasses = Convert.ToInt32(txtNumberOfClasses.Text);


                //The id will be 0 if New button was clicked
                if (selectedProgram.id == 0)
                {
                    new ProgramTable().create(selectedProgram);
                }
                else
                {
                    new ProgramTable().update(selectedProgram);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgram = new ProgramModel();
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
            if (selectedProgram.id == 0)
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
                new ProgramTable().delete(selectedProgram.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedProgram = new ProgramModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedProgram = (ProgramModel)lsvProgram.SelectedItems[0].Tag;

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

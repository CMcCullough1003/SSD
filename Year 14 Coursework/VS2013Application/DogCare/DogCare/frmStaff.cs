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
    public partial class frmStaff : Form
    {
        //Populated when an item on list is slected or when creating new record
        private StaffModel selectedStaff = new StaffModel();

        public frmStaff()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lvStaff.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<StaffModel> staffList = new StaffTable().readAll();
            
            //loop through all the records
            foreach (var person in staffList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { person.id.ToString(), person.name };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = person; 

                //add new row to the ListView
                lvStaff.Items.Add(lvi);
            }
            lvStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void lvStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                //get the details of the ListView row - make sure to cast it
                selectedStaff = (StaffModel)lvStaff.SelectedItems[0].Tag;

                //fill the input fields
                PopulateInputs();
            }catch( Exception ex){
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedStaff.id == 0) {
                return;
            }

            //fill up the input fields
            lblStaffIDReadOnly.Text = selectedStaff.id.ToString();
            txtStaffName.Text = selectedStaff.name;
        }

        private void ClearInputs() 
        {
            //set all the input fields to blank
            lblStaffIDReadOnly.Text = "";
            txtStaffName.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedStaff = new StaffModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //fill up the model with all the input fields 
                selectedStaff.name = txtStaffName.Text;

                //The id will be 0 if New button was clicked
                if (selectedStaff.id == 0)
                {
                    new StaffTable().create(selectedStaff);
                }
                else
                {
                    new StaffTable().update(selectedStaff);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedStaff = new StaffModel();
            }
            catch (Exception ex) {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedStaff.id == 0)
            {
                return;
            }

            //Don't let them delete it by accident
            DialogResult result = MessageBox.Show(
                "Wow!! Wait...are you sure?",
                "Important Question",
                MessageBoxButtons.YesNo);

            //Abort!!
            if (result == DialogResult.No) {
                return;
            }

            //Delete the reord from the table and update the ListView
            try
            {
                new StaffTable().delete(selectedStaff.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedStaff = new StaffModel();
            }
            catch (Exception ex) {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
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

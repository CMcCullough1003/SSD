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
    public partial class frmClass : Form
    {
        //Populated when an item on list is slected or when creating new record
        private ClassModel selectedClass = new ClassModel();
        List<ProgramModel> programList = new List<ProgramModel>();
        List<StaffModel> staffList = new List<StaffModel>();

        private const string PLEASE_SELECT = "Please select";

        public frmClass()
        {
            InitializeComponent();
            fetchPrograms();
            fetchStaff();
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

        private void fetchStaff()
        {
            staffList = new StaffTable().readAll();

            cbxStaff.DisplayMember = "Text";
            cbxStaff.ValueMember = "Value";

            foreach (var staff in staffList)
            {
                cbxStaff.Items.Add(new { Text = staff.name, Value = staff.id });
            }
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvClass.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ClassModel> classes = new ClassTable().readAll();

            //loop through all the records
            foreach (var clss in classes)
            {
                var programIndex = new ForeignKeyHelper().findIndexOfProgramID(programList, clss.programId);
                var programDescription = programList[programIndex].name;

                var staffIndex = new ForeignKeyHelper().findIndexOfStaffID(staffList, clss.staffId);
                var staffName = staffList[staffIndex].name;

                //create an array that will hold all the fields in a row
                var row = new string[] { clss.id.ToString(), programDescription, staffName, clss.classDate.ToString(), clss.startTime.ToString(), clss.endTime.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = clss;

                //add new row to the ListView
                lsvClass.Items.Add(lvi);
            }
            lsvClass.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedClass.id == 0)
            {
                return;
            }

            cbxProgram.Text = PLEASE_SELECT;
            cbxProgram.SelectedIndex = -1;
            cbxProgram.SelectedIndex = new ForeignKeyHelper().findIndexOfProgramID(programList, selectedClass.programId);

            cbxStaff.Text = PLEASE_SELECT;
            cbxStaff.SelectedIndex = -1;
            cbxStaff.SelectedIndex = new ForeignKeyHelper().findIndexOfStaffID(staffList, selectedClass.staffId);

            //fill up the input fields
            lblIDReadOnly.Text = selectedClass.id.ToString();
            txtDate.Text = selectedClass.classDate.ToString();
            txtStartTime.Text = selectedClass.startTime.ToString();
            txtEndTime.Text = selectedClass.endTime.ToString();
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            cbxProgram.Text = PLEASE_SELECT;
            cbxStaff.Text = PLEASE_SELECT;
            txtDate.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedClass = new ClassModel();
            ClearInputs();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cbxProgram.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a class type", "Missing input");
                return;
            }

            if (cbxStaff.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a class cost", "Missing input");
                return;
            }

            if (new InputCheckMessageBox().checkInputIsDateTime(txtDate.Text, lblDate.Text) == false)
            {
                return;
            }

            if (new InputCheckMessageBox().checkInputIsTimeSpan(txtStartTime.Text, lblStartTime.Text) == false)
            {
                return;
            }

            if (new InputCheckMessageBox().checkInputIsTimeSpan(txtEndTime.Text, lblEndTime.Text) == false)
            {
                return;
            }

            try
            {
                //fill up the model with all the input fields
                selectedClass.programId = (cbxProgram.SelectedItem as dynamic).Value;
                selectedClass.staffId = (cbxStaff.SelectedItem as dynamic).Value;
                //Convert.ToInt32(cbxProgram.SelectedItem);
                selectedClass.classDate = Convert.ToDateTime(txtDate.Text);
                selectedClass.startTime = TimeSpan.Parse(txtStartTime.Text);
                selectedClass.endTime = TimeSpan.Parse(txtEndTime.Text);


                //The id will be 0 if New button was clicked
                if (selectedClass.id == 0)
                {
                    new ClassTable().create(selectedClass);
                }
                else
                {
                    new ClassTable().update(selectedClass);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedClass = new ClassModel();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedClass.id == 0)
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
                new ClassTable().delete(selectedClass.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedClass = new ClassModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedClass = (ClassModel)lsvClass.SelectedItems[0].Tag;

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

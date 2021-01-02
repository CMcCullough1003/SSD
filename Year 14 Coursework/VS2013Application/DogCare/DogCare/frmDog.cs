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
    public partial class frmDog : Form
    {
        //Populated when an item on list is slected or when creating new record
        private DogModel selectedDog = new DogModel();
        List<ClientModel> clientList = new List<ClientModel>();
        private const string PLEASE_SELECT = "Please select";

        public frmDog()
        {
            InitializeComponent();
            fetchClients();
            RefreshList();
        }

        private void fetchClients()
        {
            clientList = new ClientTable().readAll();

            cbxClient.DisplayMember = "Text";
            cbxClient.ValueMember = "Value";

            foreach (var client in clientList)
            {
                cbxClient.Items.Add(new { Text = client.name, Value = client.id });
            }
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvDog.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<DogModel> dogs = new DogTable().readAll();

            //loop through all the records
            foreach (var dog in dogs)
            {
                var clientIndex = new ForeignKeyHelper().findIndexOfClientID(clientList,dog.clientID);
                var clientName = clientList[clientIndex].name;
                //create an array that will hold all the fields in a row
                var row = new string[] { dog.id.ToString(), dog.clientID.ToString(), clientName, dog.name, dog.age.ToString(), dog.breed, dog.experienceOrQualification.ToString() };
                var lvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lvi.Tag = dog;

                //add new row to the ListView
                lsvDog.Items.Add(lvi);
            }
        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedDog.id == 0)
            {
                return;
            }

            cbxClient.Text = PLEASE_SELECT;
            cbxClient.SelectedIndex = -1;
            cbxClient.SelectedIndex = new ForeignKeyHelper().findIndexOfClientID(clientList, selectedDog.clientID);

            //fill up the input fields
            lblIDReadOnly.Text = selectedDog.id.ToString();
            txtName.Text = selectedDog.name;
            txtAge.Text = selectedDog.age.ToString();
            txtBreed.Text = selectedDog.breed;
            if (selectedDog.experienceOrQualification == true)
            {
                rbtnYes.Checked = true;
            }
            if (selectedDog.experienceOrQualification == false)
            {
                rbtnNo.Checked = true;
            }
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblIDReadOnly.Text = "";
            cbxClient.Text = PLEASE_SELECT;
            txtName.Text = "";
            txtAge.Text = "";
            txtBreed.Text = "";
            rbtnYes.Checked = false;
            rbtnNo.Checked = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedDog = new DogModel();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxClient.Text == PLEASE_SELECT)
            {
                MessageBox.Show("Please select a client's name", "Missing input");
                return;
            }

            if (rbtnYes.Checked == false && rbtnNo.Checked == false)
            {
                MessageBox.Show("Please select a level of experience", "Missing input");
                return;
            }

            if (new InputCheckMessageBox().checkInputIsInt(txtAge.Text, lblAge.Text) == false)
            {
                return;
            }

            try
            {
                //fill up the model with all the input fields
                selectedDog.clientID = (cbxClient.SelectedItem as dynamic).Value;
                //Convert.ToInt32(cbxClient.SelectedItem);
                selectedDog.name = txtName.Text;
                selectedDog.age = Convert.ToInt32(txtAge.Text);
                selectedDog.breed = txtBreed.Text;
                if (rbtnYes.Checked)
                {
                    selectedDog.experienceOrQualification = true;
                }
                if (rbtnNo.Checked)
                {
                    selectedDog.experienceOrQualification = false;
                }
                

                //The id will be 0 if New button was clicked
                if (selectedDog.id == 0)
                {
                    new DogTable().create(selectedDog);
                }
                else
                {
                    new DogTable().update(selectedDog);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedDog = new DogModel();
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
            if (selectedDog.id == 0)
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
                new DogTable().delete(selectedDog.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedDog = new DogModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //get the details of the ListView row - make sure to cast it
                selectedDog = (DogModel)lsvDog.SelectedItems[0].Tag;

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

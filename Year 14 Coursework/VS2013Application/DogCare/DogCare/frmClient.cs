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
    public partial class frmClient : Form
    {
        //Populated when an item on list is selected or when creating new record
        private ClientModel selectedClient = new ClientModel();

        public frmClient()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvClient.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ClientModel> clientList = new ClientTable().readAll();

            //loop through all the records
            foreach (var client in clientList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { client.id.ToString(), client.name, client.phone, client.email };
                var lsvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lsvi.Tag = client;

                //add new row to the ListView
                lsvClient.Items.Add(lsvi);
            }
            lsvClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void PopulateInputs()
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedClient.id == 0)
            {
                return;
            }

            //fill up the input fields
            lblClientIDRead.Text = selectedClient.id.ToString();
            txbName.Text = selectedClient.name;
            txbPhone.Text = selectedClient.phone;
            txbEmail.Text = selectedClient.email;
        }

        private void ClearInputs()
        {
            //set all the input fields to blank
            lblClientIDRead.Text = "New client";
            txbName.Text = "";
            txbPhone.Text = "";
            txbEmail.Text = "";
        }

        private void btnNewClient_Click_1(object sender, EventArgs e)
        {
            //make sure the model has no old information in it
            selectedClient = new ClientModel();
            ClearInputs();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                //fill up the model with all the input fields 
                selectedClient.name = txbName.Text;
                selectedClient.phone = txbPhone.Text;
                selectedClient.email = txbEmail.Text;

                //The id will be 0 if New button was clicked
                if (selectedClient.id == 0)
                {
                    new ClientTable().create(selectedClient);
                }
                else
                {
                    new ClientTable().update(selectedClient);
                }

                //reset everything
                ClearInputs();
                RefreshList();
                selectedClient = new ClientModel();
            }
            catch (Exception ex)
            {
                String message = new ExceptionMessageGenerator().generateMessage(ex.Message);
                MessageBox.Show(message);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            //If this is 0 then there is nothing to show. The model is blank
            if (selectedClient.id == 0)
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
                new ClientTable().delete(selectedClient.id);

                //reset everything
                ClearInputs();
                RefreshList();
                selectedClient = new ClientModel();
            }
            catch (Exception ex)
            {
                new ExceptionMessageGenerator().generateMessage(ex.Message);
            }
        }

        private void lsvClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try {
                //get the details of the ListView row - make sure to cast it
                selectedClient = (ClientModel)lsvClient.SelectedItems[0].Tag;

                //fill the input fields
                PopulateInputs();
            }
 
            catch( Exception ex){
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

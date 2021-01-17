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
    public partial class frmReportEnrollment : Form
    {
        public frmReportEnrollment()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvClasses.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ReportEnrollmentModel> enrollmentList = new Reports().readReportEnrollment();

            //loop through all the records
            foreach (var thisClass in enrollmentList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { thisClass.programName, thisClass.programVarietyName, thisClass.firstClassDate.ToString(), thisClass.numberEnrolled.ToString(), thisClass.maxSpaces.ToString(), thisClass.freeSpaces.ToString() };
                var lsvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lsvi.Tag = thisClass;

                //add new row to the ListView
                lsvClasses.Items.Add(lsvi);
            }
            lsvClasses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lsvClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

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

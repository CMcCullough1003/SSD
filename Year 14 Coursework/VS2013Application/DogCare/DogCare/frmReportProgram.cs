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
    public partial class frmReportProgram : Form
    {
        public frmReportProgram()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvClasses.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ReportProgramModel> programList = new Reports().readReportProgram();

            //loop through all the records
            foreach (var thisClass in programList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { thisClass.programName, thisClass.programVariety, thisClass.NoOfClasses.ToString(), thisClass.NumberOfClassesArranged.ToString(), thisClass.missingClasses.ToString() };
                var lsvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lsvi.Tag = thisClass;

                //add new row to the ListView
                lsvClasses.Items.Add(lsvi);
            }
            lsvClasses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

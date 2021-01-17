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
    public partial class frmReportSchedule : Form
    {
        public frmReportSchedule()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            //clear all the items from the ListView
            lsvClasses.Items.Clear(); // make sure it is not just lvXXX.Clear()

            //read all the records from the table
            List<ReportScheduleModel> scheduleList = new Reports().readReportSchedule();

            //loop through all the records
            foreach (var thisClass in scheduleList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { thisClass.classDate.ToString().Substring(0, 10), thisClass.startTime.ToString().Substring(0, 5), thisClass.endTime.ToString().Substring(0, 5), thisClass.programVarietyName, thisClass.programName, thisClass.staffName };
                var lsvi = new ListViewItem(row);

                //Save the model in the tag property so we can use it if row is selected
                lsvi.Tag = thisClass;

                //add new row to the ListView
                lsvClasses.Items.Add(lsvi);
            }
            lsvClasses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void frmReportSchedule_Load(object sender, EventArgs e)
        {

        }

        private void lsvClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvAttendees.Items.Clear();

            if (lsvClasses.SelectedItems.Count == 0) 
            {
                return;
            }

            //get the details of the ListView row - make sure to cast it
            var selectedClass = (ReportScheduleModel)lsvClasses.SelectedItems[0].Tag;

            List<ReportAttendeesModel> reportAttendeesList = new Reports().readReportAttendees(selectedClass.programId);

            foreach (var attendee in reportAttendeesList)
            {
                //create an array that will hold all the fields in a row
                var row = new string[] { attendee.clientName, attendee.dogName};
                var lsvi = new ListViewItem(row);

                //add new row to the ListView
                lsvAttendees.Items.Add(lsvi);
            }
            lsvAttendees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); 
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

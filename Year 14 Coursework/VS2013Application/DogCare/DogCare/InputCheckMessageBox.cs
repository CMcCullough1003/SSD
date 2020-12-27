using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCare
{
    class InputCheckMessageBox
    {
        public Boolean checkInputIsDouble(string number, string fieldName)
        {
            try
            {
                Convert.ToDouble(number);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(fieldName + " must be a number.");
                return false;
            }
        }

        public Boolean checkInputIsInt(string number, string fieldName)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(fieldName + " must be a number.");
                return false;
            }
        }

        public Boolean checkInputIsTimeSpan(string time, string fieldName)
        {
            try
            {
                TimeSpan.Parse(time);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(fieldName + " must be in the format hh:mm.");
                return false;
            }
        }

        public Boolean checkInputIsDateTime(string dateTime, string fieldName)
        {
            try
            {
                Convert.ToDateTime(dateTime);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(fieldName + " must be in the format dd/mm/yyyy.");
                return false;
            }
        }
    }
}

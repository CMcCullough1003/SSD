using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_13_Coursework
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        public void moveToNextScreen()
        {
            this.Close();
            Form moveToNextScreen = new frmGameInfo();
            moveToNextScreen.Show();
        }
    }
}

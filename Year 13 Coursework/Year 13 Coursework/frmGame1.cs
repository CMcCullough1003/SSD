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
    public partial class frmGame1 : frmGame
    {
        public frmGame1()
        {
            InitializeComponent();
        }

        private void FrmGame1_Load(object sender, EventArgs e)
        {
            //pbxAvatar.Image = Image.FromFile(@"");
        }

        private void PbxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
        }
    }
}

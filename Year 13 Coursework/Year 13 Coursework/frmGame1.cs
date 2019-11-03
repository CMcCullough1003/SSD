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
        private int _ticks1;
        public frmGame1()
        {
            InitializeComponent();

            tmr1.Start();
        }

        private void Tmr1_Tick(object sender, EventArgs e)
        {
            _ticks1++;
        }

        private void FrmGame1_Load(object sender, EventArgs e)
        {
            pbxAvatar = getAvatarImage();
            int[] array = new int[] {}
        }

        private void PbxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
        }

        //pass in the filename of the current users avatar
        public Image getAvatarImage(string filename)
        {
            //default image so never returning a null
            Image image = Properties.Resources.bee;
            switch (filename)
            {
                case "bee.png": image = Properties.Resources.bee; break;
                case "chicken.png": image = Properties.Resources.chicken; break;
                case "elephant.png": image = Properties.Resources.elephant; break;
                case "cow.png": image = Properties.Resources.cow; break;
                case "pig.png": image = Properties.Resources.pig; break;
                case "triceratops.png": image = Properties.Resources.triceratops; break;
                case "dog.png": image = Properties.Resources.dog; break;
                case "ghost.png": image = Properties.Resources.ghost; break;
                case "sheep.png": image = Properties.Resources.sheep; break;
            }
            //switch on the name of the filename 
            //assign the image to the variable
            return image;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Year_13_Coursework.Tools
{
    class Avatars
    {
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

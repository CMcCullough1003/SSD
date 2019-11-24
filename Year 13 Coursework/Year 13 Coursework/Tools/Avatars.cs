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
            Image image = Properties.Resources.globe;
            switch (filename)
            {
                case "bee.png": image = Properties.Resources.signs; break;
                case "chicken.png": image = Properties.Resources.camera; break;
                case "cow.png": image = Properties.Resources._18camp_115462; break;
                case "pig.png": image = Properties.Resources.cocktail; break;
                case "triceratops.png": image = Properties.Resources.globe; break;
                case "sheep.png": image = Properties.Resources.icecream; break;
            }
            //switch on the name of the filename 
            //assign the image to the variable
            return image;
        }

    }
}

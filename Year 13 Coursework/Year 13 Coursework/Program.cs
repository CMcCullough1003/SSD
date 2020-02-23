using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_13_Coursework.Tools;

namespace Year_13_Coursework
{
    //For commenting, I chose to use descriptive method and variable names to try and make the process as easily understandable as possible
    ////Instead, I used comments only to detail ideas that I thought were particularly hard to understand or to group similar methods toghether
    static class Program
    {
        public static User currentUser = new User();
        public static int currentGame = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}

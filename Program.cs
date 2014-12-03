using System;
using System.Collections.Generic;

using System.Windows.Forms;
using LibraryApp.Classes;

namespace LibraryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new AddBook());
=======
            Application.Run(new WelcomePage());
>>>>>>> 528bf7ae81a758427f390978374745d595146d2a
        }
    }
}

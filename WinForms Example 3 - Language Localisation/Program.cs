﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms_Example_3___Language_Localisation
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
            Application.Run(new frmLanguage());
        }
    }
}

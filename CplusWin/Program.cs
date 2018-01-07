using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Presentation;
using GApp.DAL.Exceptions;

namespace AppWin
{
    static class  Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //[STAThread]
        //static void Main()
        //{
        //    if (!System.Diagnostics.Debugger.IsAttached)
        //    {
        //        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
        //        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        //    }
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new MainForm());
        //}

        //private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    MessageBox.Show(e.ExceptionObject.ToString());
        //    // Workaround for Windows 10.0.10586 bug:
        //    AppDomain.CurrentDomain.UnhandledException -= CurrentDomain_UnhandledException;
        //    Environment.Exit(1);
        //}
    }
}

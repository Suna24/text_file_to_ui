using System;
using System.Windows.Forms;

namespace TextFileToUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserInfoForm userInfoForm = new UserInfoForm();
            Application.Run(userInfoForm);
        }
    }
}

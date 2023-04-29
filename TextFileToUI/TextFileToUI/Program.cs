using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileToUI.Classes;

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

            UserFileReader userFileReader = new UserFileReader("C:\\Users\\basti\\Documents\\ESIEA\\3A_Semestre_2_CROATIE\\Software_Engineering\\SE - Task with printing data from a text file\\user1.txt");
            UserParser userParser = new UserParser(userFileReader.ReadFile());
            User user = userParser.ParseData();
            UserDisplayer userDisplayer = new UserDisplayer(userInfoForm, user);
            userDisplayer.DisplayUser();

            Application.Run(userInfoForm);

        }
    }
}

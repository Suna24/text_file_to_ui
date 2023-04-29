using System;
using System.Windows.Forms;
using TextFileToUI.Classes;

namespace TextFileToUI
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = openFileDialog.FileName;
                    UserFileReader userFileReader = new UserFileReader(selectedFolder);
                    UserParser userParser = new UserParser(userFileReader.ReadFile());
                    User user = userParser.ParseData();
                    UserDisplayer userDisplayer = new UserDisplayer(this, user);
                    userDisplayer.DisplayUser();
                }
            }
        }
    }
}

using System;

namespace TextFileToUI.Classes
{
    public class UserDisplayer
    {
        public UserInfoForm UserInfoForm { get; set; }
        public User User { get; set; }

        public UserDisplayer(UserInfoForm userInfoForm, User user)
        {
            UserInfoForm = userInfoForm;
            User = user;
        }

        public void DisplayUser()
        {
            if (User == null)
            {
                Console.WriteLine("There is no such user to display");
            }

            if (UserInfoForm != null)
            {
                /* Modify the text of the textboxes */
                UserInfoForm.Controls["FullNameTextBox"].Text = User.FullName;
                UserInfoForm.Controls["YearOfBirthTextBox"].Text = User.YearOfBirth.ToString();
                UserInfoForm.Controls["CityTextBox"].Text = User.CityOfOrigin;
                UserInfoForm.Controls["FacultyTextBox"].Text = User.Faculty;
                UserInfoForm.Controls["RoleTextBox"].Text = User.Role.Name;
                UserInfoForm.Controls["RoleSpecificAttributeTextBox"].Text = User.Role.SpecificAttribute.Item2;

                /* Modify the specific label text */
                UserInfoForm.Controls["RoleSpecificAttributeLabel"].Text = User.Role.SpecificAttribute.Item1;
            } else
            {
                Console.WriteLine("There is no form to display the user");
            }
        }
    }
}

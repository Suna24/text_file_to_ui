using Newtonsoft.Json.Linq;

namespace TextFileToUI.Classes
{
    public class UserParser
    {
        public string UserStringData { get; set; }

        public UserParser(string userStringData)
        {
            UserStringData = userStringData;
        }

        public User ParseData()
        {
            User user = new User();
            JObject jsonObject = JObject.Parse(UserStringData);

            /* Classic attributes for the user */
            user.FullName = (string)jsonObject["Name"] + " " + (string)jsonObject["Surname"];
            user.YearOfBirth = (int)jsonObject["Year of birth"];
            user.CityOfOrigin = (string)jsonObject["City of origin"];
            user.Faculty = (string)jsonObject["Faculty"];
            user.FavoriteCourse = (string)jsonObject["Favorite course"];

            /* Role attribute for the user (optional parameter) */
            if (jsonObject.ContainsKey("Specific attribute"))
            {
                user.Role = new Role((string)jsonObject["Role"], (string)jsonObject["Specific attribute"]);
            } else
            {
                user.Role = new Role((string)jsonObject["Role"]);
            }
            
            return user;
        }
    }
}

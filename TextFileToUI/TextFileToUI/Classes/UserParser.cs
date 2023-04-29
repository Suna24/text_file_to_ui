using Newtonsoft.Json.Linq;
using System;
using System.Linq;

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

            /* Specific attribute for the role */
            JProperty lastJson = jsonObject.Properties().Last();
            (string, string) tuple = (lastJson.Name, (string)lastJson.Value);
            user.Role = new Role((string)jsonObject["Role"], tuple);
            
            return user;
        }
    }
}

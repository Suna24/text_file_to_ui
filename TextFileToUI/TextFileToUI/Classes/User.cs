using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileToUI.Classes
{
    public class User
    {
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public string CityOfOrigin { get; set; }
        public string Faculty { get; set; }
        public string FavoriteCourse { get; set; }
        public Role Role { get; set; }
    }
}

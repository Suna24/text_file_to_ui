using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            /* Not implemented yet */
            return null;
        }
    }
}

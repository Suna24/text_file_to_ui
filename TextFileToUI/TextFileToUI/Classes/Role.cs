using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileToUI.Classes
{
    public class Role
    {

        public string Name { get; set; }
        public string SpecificAttribute { get; set; }

        public Role(string name, string specificAttribute="")
        {
            Name = name;
            SpecificAttribute = specificAttribute;
        }
    }
}

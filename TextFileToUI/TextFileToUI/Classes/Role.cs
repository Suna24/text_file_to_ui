
using System;

namespace TextFileToUI.Classes
{
    public class Role
    {

        public string Name { get; set; }
        public (string, string) SpecificAttribute { get; set; }

        public Role(string name, (string, string) specificAttribute)
        {
            Name = name;
            SpecificAttribute = specificAttribute;
        }
    }
}

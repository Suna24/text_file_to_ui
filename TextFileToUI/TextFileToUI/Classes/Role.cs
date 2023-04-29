
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

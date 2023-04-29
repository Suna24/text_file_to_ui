using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;


namespace TextFileToUI
{
    public class UserFileReader
    {
        public string FilePath { get; set; }

        public UserFileReader(string filePath)
        {
            FilePath = filePath;
        }

        public void IncreaseNumberOfAccess()
        {
            /* Not implemented yet */
        }

        public string ReadFile()
        {

            var dict = new Dictionary<string, string>();

            foreach (var line in File.ReadAllLines(FilePath))
            {
                var keyValue = line.Split('=');
                if (keyValue[0] != "File accessed times")
                {
                    dict.Add(keyValue[0], keyValue[1]);
                }
            }
                
            return JsonConvert.SerializeObject(dict);
        }
    }
}

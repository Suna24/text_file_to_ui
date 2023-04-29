using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace TextFileToUI
{
    public class UserFileReader
    {
        public string FilePath { get; set; }

        public UserFileReader(string filePath)
        {
            FilePath = filePath;
        }

        /// <summary>
        /// This method is used to increase the number of access of the file by writing the new dictionnary in the file
        /// </summary>
        public void IncreaseNumberOfAccess(Dictionary<string, string> entireDict)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (KeyValuePair<string, string> keyValuePair in entireDict)
                {
                    writer.WriteLine($"{keyValuePair.Key}={keyValuePair.Value}");
                }
            }
        }

        /// <summary>
        /// This method is used to read the file and return the json string of the file
        /// </summary>
        public string ReadFile()
        {
            
            var dictUser = new Dictionary<string, string>();
            var lines = File.ReadAllLines(FilePath);

            /* We go through all lines and add the key value pair in the dictionnary */
            for(int i = 0; i < lines.Length - 1; i++)
            {
                var keyValue = lines[i].Split('=');
                dictUser.Add(keyValue[0], keyValue[1]);
            }

            /* We serialize the dictionnary to a json string that will be return at the end */
            string jsonToReturn = JsonConvert.SerializeObject(dictUser);

            /* We add the last key value pair in the dictionnary (File accessed times attribute) */
            var lastKeyValuePair = lines[lines.Length - 1].Split('=');
            dictUser.Add(lastKeyValuePair[0], lastKeyValuePair[1]);

            /* We increase this value by 1 */
            dictUser["File accessed times"] = (int.Parse(dictUser["File accessed times"]) + 1).ToString();
            IncreaseNumberOfAccess(dictUser);

            return jsonToReturn;
        }
    }
}

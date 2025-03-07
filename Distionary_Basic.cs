using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class Distionary_Basic
    {
        public void distionary()
        {
            Dictionary<int, string> distionary = new Dictionary<int, string>
            {
                { 1, "PRUTHVI" },
                { 2, "Guru" }
            };

            for(int i = 0; i < distionary.Count; i++)
            {
                KeyValuePair<int, string> keyValuePair = distionary.ElementAt(i);

                Console.WriteLine($"Key : {keyValuePair.Key} | Value : {keyValuePair.Value}");
            }

            foreach(KeyValuePair<int, string> pair in distionary)
            {
                Console.WriteLine($"key : {pair.Key} | Value : {pair.Value}");
            }

            Dictionary<string, string> techers = new Dictionary<string, string>
            {
                { "JAVA", "MANOJ" },
                { "QA", "JAYESH" }
            };

            if(techers.TryGetValue("JAVA", out string teacher))
            {
                Console.WriteLine($"Key is found and value is: {teacher}");
            }
            else
            {
                Console.WriteLine("Key not founs!");
            }

            if (techers.ContainsKey("JAVA"))
            {
                techers.Remove("JAVA");
            }

            foreach(var iteams in techers)
            {
                Console.WriteLine($"Name of Language: {iteams.Key} and TeachLead: {iteams.Value}");
            }
        }
    }
}

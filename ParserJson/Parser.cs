using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace ParserJson
{
    static class Parser
    {
        static Dictionary<string, string> CreatePairs(Root root)
        {
            Dictionary<string, string> pairsJson = new Dictionary<string, string>();
            PropertyInfo[] properties = root.Section1.GetType().GetProperties();
            foreach (var property in properties)
            {
                string key = root.Section1.GetType().Name.ToLower();
                string key1, value1;
                if (property.Name == "Value1")
                {
                    key1 = key + ":" + property.Name.ToLower();
                    value1 = root.Section1.Value1;
                }
                else
                {
                    key1 = key + ":" + property.Name.ToLower() + ":" + property.PropertyType.GetProperties()[0].Name.ToLower();
                    value1 = root.Section1.Subsection1.Value2;
                }
                if (!pairsJson.ContainsKey(key1))
                    pairsJson.Add(key1, value1);
                else
                    Console.WriteLine("The key already exists!");
            }
            return pairsJson;
        }
        public static async Task ParserJson(string path)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    Root input = await JsonSerializer.DeserializeAsync<Root>(fs);
                    pairs = CreatePairs(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Malformed JSON file!");
                }
            }
            if (pairs != null)
                foreach (var pair in pairs)
                {
                    Console.WriteLine(String.Format("\"{0}\" = \"{1}\"", pair.Key, pair.Value));
                }
        }
    }
}

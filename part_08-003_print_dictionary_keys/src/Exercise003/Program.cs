namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static void PrintKeys(Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key, kvp.Key, kvp.Value);
            }
        }
        public static void PrintKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                if (kvp.Key.Contains(text))
                {
                    Console.WriteLine(kvp.Key, kvp.Key, kvp.Value);
                }
            }
        }
        public static void PrintValuesOfKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                if (kvp.Key.Contains(text))
                {
                    Console.WriteLine(kvp.Value, kvp.Key, kvp.Value);
                }
            }
        }
    }
}
namespace Exercise004
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("/myFile.txt"))
            {

                sw.WriteLine("Hello file!"); //writes the string "Hello file!" and line change to the file
                sw.WriteLine("More text");
                sw.Write("And a little extra"); // writes the string "And a little extra" to the file without a line change
            }
        }
    }
}
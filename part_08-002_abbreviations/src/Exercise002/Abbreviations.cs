namespace Exercise002
{
    using System;
    using System.Collections.Generic;
    public class Abbreviations
    {
        private string abbreviation;
        private string explanation;

        public Abbreviations()
        {
            //this.abbreviation = abbreviation;

        }
        Dictionary<string, string> abbrev = new Dictionary<string, string>();

        public void AddAbbreviation(string abbreviation, string explanation)
        {
            if (abbrev.ContainsKey(abbreviation))
            {
                Console.WriteLine("not found");
            }
            else
            {
                abbrev.Add(abbreviation, explanation);
            }
        }

        public bool HasAbbreviation(string abbreviation)
        {
            if (abbrev.ContainsKey(abbreviation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string FindExplanationFor(string abbreviation)
        {
            if (!abbrev.ContainsKey(abbreviation))
            {
                return "not found";
            }
            else
            {
                return abbrev[abbreviation];
            }
        }

    }
}
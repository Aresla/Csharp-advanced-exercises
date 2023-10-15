namespace Exercise008
{
    using System;
    using System.Collections.Generic;

    public class DictionaryOfManyTranslations
    {
        private Dictionary<string, List<string>> dictionaryForTranslation;
        public DictionaryOfManyTranslations()
        {
            this.dictionaryForTranslation = new Dictionary<string, List<string>>();
        }

        public void Add(string word, string translation)
        {
            if (!this.dictionaryForTranslation.ContainsKey(word))
            {
                this.dictionaryForTranslation.Add(word, new List<string>());
            }
            this.dictionaryForTranslation[word].Add(translation);
        }
        public List<string> Translate(string word)
        {
            if (this.dictionaryForTranslation.ContainsKey(word))
            {
                return this.dictionaryForTranslation[word];
            }
            else
            {
                List<string> list = new List<string>();
                return list;
            }

        }
        public void Remove(string word)
        {
            if (this.dictionaryForTranslation.ContainsKey(word))
            {
                this.dictionaryForTranslation.Remove(word);
            }
        }
    }
}
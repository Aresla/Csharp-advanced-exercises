namespace Exercise005
{
    using System;

    public class SaveableDictionary
    {
        public string file;
        public List<string[]> list;
        public SaveableDictionary()
        {
            this.list = new List<string[]>();
        }
        public SaveableDictionary(string file)
        {
            this.file = file;
            this.list = new List<string[]>();
        }

        public bool Load()
        {
            if (!File.Exists(this.file))
            {
                // throw new System.IO.FileNotFoundException();
                return false;
            }
            try
            {
                string[] lines = File.ReadAllLines(this.file);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    this.Add(parts[0], parts[1]);
                }

                return true;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                return false;
            }
        }

        private int getWordIndexInList(List<string[]> list, string word)
        {
            for (int index = 0; index < list.Count; index++)
            {
                var item = list[index];
                if (word == item[0] || word == item[1])
                {
                    return index;
                }
            }
            return -1;
        }

        public void Add(string word, string translation)
        {
            if (this.list.Count() == 0)
            {
                string[] array = { word, translation };
                this.list.Add(array);
                return;
            }
            else
            {
                int itemIndex = this.getWordIndexInList(this.list, word);
                if (itemIndex == -1)
                {
                    string[] array = { word, translation };
                    this.list.Add(array);
                }
            }
        }

        public void Delete(string word)
        {
            int itemIndex = this.getWordIndexInList(this.list, word);

            if (itemIndex != -1)
            {
                this.list.RemoveAt(itemIndex);
            }

        }

        public string Translate(string word)
        {
            foreach (var arr in this.list)
            {
                if (word == arr[0])
                {
                    return arr[1];
                }
                else if (word == arr[1])
                {
                    return arr[0];
                }

            }
            return null;
        }

        public bool Save()
        {
            try
            {
                File.Replace(this.list, this.file, this.list);
                //File.WriteAllLines(this.list, this.file);
                return true;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
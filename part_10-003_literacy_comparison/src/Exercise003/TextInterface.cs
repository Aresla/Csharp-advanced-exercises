namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here
        public List<Book> list;

        public TextInterface()
        {
            this.list = new List<Book>();
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Input the name of the book, empty stops:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("Input the age recommendation:");
                int ageRecommendation = Convert.ToInt32(Console.ReadLine());
                Book book = new Book(name, ageRecommendation);
                this.list.Add(book);
            }
            Console.WriteLine(this.list.Count() + " books in total.");
            Console.WriteLine("Books:");
            foreach (Book book in this.list)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
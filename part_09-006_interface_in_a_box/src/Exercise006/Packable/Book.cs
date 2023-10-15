namespace Exercise006
{
    public class Book : IPackable
    {
        private string author;
        private string name;
        private int publicationYear;


        public Book(string author, string name, int publicationYear)
        {
            this.author = author;
            this.name = name;
            this.publicationYear = publicationYear;
        }

        public int Weight()
        {
            return 1;
        }

        public override string ToString()
        {
            return this.author + ": " + this.name + " (" + this.publicationYear + ")";
        }
    }
}
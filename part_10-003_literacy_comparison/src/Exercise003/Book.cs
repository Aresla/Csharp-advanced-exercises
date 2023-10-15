namespace Exercise003
{
    using System;
    public class Book : IComparable<Book>
    {

        public string name { get; }
        public int ageRecommendation { get; }

        public Book(string name, int ageRecommendation)
        {
            this.name = name;
            this.ageRecommendation = ageRecommendation;
        }


        public override string ToString()
        {
            // Don't touch this
            return this.name + " (recommended for " + this.ageRecommendation + " year-olds or older)";
        }


        public int CompareTo(Book other)
        {
            if (other == null)
            {
                return 1;
            }
            if (this.ageRecommendation == other.ageRecommendation)
            {
                return string.Compare(this.name, other.name);
            }
            return this.ageRecommendation - other.ageRecommendation;
        }

    }
}
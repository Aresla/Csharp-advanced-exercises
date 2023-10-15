namespace Exercise001
{
    using System;

    public class Human : IComparable<Human>
    {
        public int wage { get; }
        public string name { get; }

        public Human(string name, int wage)
        {
            this.name = name;
            this.wage = wage;
        }

        public int CompareTo(Human another)
        {
            if (another == null)
            {
                return -1;
            }
            if (this.wage == another.wage)
            {
                return 0;
            }
            else if (this.wage > another.wage)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }


        public override string ToString()
        {
            return name + " " + wage;
        }
    }
}
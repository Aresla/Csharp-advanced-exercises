namespace Exercise002
{
    public class Student : IComparable<Student>
    {

        public string name { get; }

        public Student(string name)
        {
            this.name = name;
        }


        public override string ToString()
        {
            return this.name;
        }

        public int CompareTo(Student another)
        {
            if (another == null)
            {
                return -1;
            }
            return this.name.CompareTo(another.name);
        }
    }
}
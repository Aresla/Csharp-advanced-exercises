namespace Exercise003
{
    using System;
    public class Person
    {

        public string name { get; }
        public int age { get; }

        public Person(string name, int age)
        {
            if (name == null || name == "" || name.Count() > 40 || age > 120 || age < 0)
            {
                throw new ArgumentException("The arguments are wrong");
            }
            this.name = name;
            this.age = age;
        }
    }
}
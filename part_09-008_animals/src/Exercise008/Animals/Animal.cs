namespace Exercise008
{
    public abstract class Animal
    {
        public string name { get; set; }

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Eat();

        public abstract void Sleep();

    }
}
namespace Exercise008
{
    public class Cat : Animal, INoiseCapable
    {

        public Cat() : base("Cat")
        { }

        public Cat(string catName) : base(catName)
        { }
        public void Purr()
        {
            Console.WriteLine(this.name + " purrs");
        }
        public override void Eat()
        {
            Console.WriteLine(this.name + " eats");
        }
        public override void Sleep()
        {
            Console.WriteLine(this.name + " sleeps");
        }

        public void MakeNoise()
        {
            Purr();
        }
    }
}
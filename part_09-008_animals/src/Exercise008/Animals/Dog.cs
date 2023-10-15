namespace Exercise008
{
    public class Dog : Animal, INoiseCapable
    {
        public Dog() : base("Dog")
        { }

        public Dog(string dogName) : base(dogName)
        { }

        public void Bark()
        {
            Console.WriteLine(this.name + " barks");
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
            Bark();
        }
    }
}
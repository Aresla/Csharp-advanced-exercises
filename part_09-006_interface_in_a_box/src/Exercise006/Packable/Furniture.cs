namespace Exercise006
{
    public class Furniture : IPackable
    {
        private string type;
        private string color;
        private int weight;


        public Furniture(string type, string color, int weight)
        {
            this.type = type;
            this.color = color;
            this.weight = weight;
        }

        public int Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.color + " " + this.type + " - weight " + this.weight + " kg";
        }
    }
}

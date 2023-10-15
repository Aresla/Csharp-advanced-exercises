namespace Exercise007
{
    public class Organism : IMovable
    {
        private int x;
        private int y;
        public Organism(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {this.x}; y: {this.y}";
        }

        public void Move(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}
namespace Exercise007
{
    public class Herd : IMovable
    {
        private List<IMovable> list;

        public Herd()
        {
            this.list = new List<IMovable>();
        }

        public override string ToString()
        {
            foreach (IMovable item in this.list)
            {
                Console.WriteLine(item.ToString());
            }
            return "";
        }
        public void AddToHerd(IMovable movable)
        {
            this.list.Add(movable);
        }
        public void Move(int dx, int dy)
        {
            foreach (IMovable item in this.list)
            {
                item.Move(dx, dy);
            }
        }
    }
}
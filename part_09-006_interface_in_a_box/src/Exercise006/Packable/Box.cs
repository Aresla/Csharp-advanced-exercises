namespace Exercise006
{
    public class Box : IPackable
    {
        private int maxCapacity;
        List<IPackable> list;

        public Box(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
            this.list = new List<IPackable>();

        }
        public void Add(IPackable item)
        {
            if (item.Weight() <= (this.maxCapacity - this.Weight()))
            {
                list.Add(item);
            }
        }

        public int Weight()
        {
            int weight = 0;
            foreach (IPackable item in this.list)
            {
                weight += item.Weight();
            }
            return weight;
        }

        public override string ToString()
        {
            return list.Count + " items," + " total weight " + this.Weight() + " kg";
        }
    }
}
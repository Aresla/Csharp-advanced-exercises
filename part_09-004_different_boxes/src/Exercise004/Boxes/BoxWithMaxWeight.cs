namespace Exercise004
{
    public class BoxWithMaxWeight : Box
    {
        private int capacity;
        private List<Item> list;
        public BoxWithMaxWeight(int capacity)
        {
            this.capacity = capacity;
            this.list = new List<Item>();
        }

        public override void Add(Item item)
        {
            int weightOfTheBox = 0;
            int i = 0;
            while (i < this.list.Count)
            {
                int itemWeight = this.list[i].weight;
                weightOfTheBox += itemWeight;
                i = i + 1;
            }
            if (item.weight <= (this.capacity - weightOfTheBox))
            {
                this.list.Add(item);
            }
        }

        public override bool IsInBox(Item item)
        {
            Item foundItem = this.list.Find(listItem => listItem.name == item.name);
            return !(foundItem == null);
        }
    }
}
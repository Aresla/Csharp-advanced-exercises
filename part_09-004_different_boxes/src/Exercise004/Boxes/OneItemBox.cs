namespace Exercise004
{
    public class OneItemBox : Box
    {
        private int capacity;
        private List<Item> list;

        public OneItemBox()
        {
            this.capacity = 1;
            this.list = new List<Item>();
        }

        public override void Add(Item item)
        {
            if (this.list.Count == 0)
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
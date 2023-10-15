namespace Exercise004
{
    public class Item
    {
        public string name { get; set; }
        public int weight { get; set; }
        public Item(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public Item(string name) : this(name, 0) { }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            // convert the object to a Item object
            Item comparedItem = (Item)compared;
            // if the values of the object variables are equal, the objects are, too
            return this.name == comparedItem.name;
        }
        public override int GetHashCode()
        {
            if (this.name == null)
            {
                return this.weight;
            }
            return this.name.GetHashCode();
        }
    }
}
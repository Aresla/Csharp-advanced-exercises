namespace Exercise003
{
    public class ProductWarehouseWithHistory : ProductWarehouse
    {
        //   public int balance;
        public ChangeHistory history;
        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
        {
            base.balance = initialBalance;
            this.history = new ChangeHistory();
            this.history.Add(initialBalance);

        }

        public string History()
        {
            return this.history.ToString();
        }

        new public void AddToWarehouse(int amount)
        {
            base.AddToWarehouse(amount);
            this.history.Add(base.balance);
        }
        new public int TakeFromWarehouse(int amount)
        {
            int recieved = base.TakeFromWarehouse(amount);
            history.Add(base.balance);
            return recieved;
        }
    }
}
namespace Exercise003
{
    public class ProductWarehouse : Warehouse
    {
        public string productName { get; set; }


        public ProductWarehouse(string productName, int capacity) : base(capacity)
        {
            this.productName = productName;
        }

        public override string ToString()
        {
            return this.productName + ": " + base.ToString();
        }
    }
}
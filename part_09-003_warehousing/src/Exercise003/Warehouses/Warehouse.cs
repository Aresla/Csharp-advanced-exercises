namespace Exercise003
{

    public class Warehouse
    {
        public int balance { get; set; }
        public int capacity { get; set; }

        public Warehouse(int capacity)
        {
            if (capacity > 0)
            {
                this.capacity = capacity;
            }
            else
            {
                this.capacity = 0;
            }

            this.balance = 0;
        }

        public int HowMuchSpaceLeft()
        {
            return this.capacity - this.balance;
        }

        public void AddToWarehouse(int amount)
        {
            if (amount < 0)
            {
                return;
            }
            if (amount <= HowMuchSpaceLeft())
            {
                this.balance += amount;
            }
            else
            {
                this.balance = this.capacity;
            }
        }

        public int TakeFromWarehouse(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            if (amount > this.balance)
            {
                int allThatWeCan = this.balance;
                this.balance = 0;
                return allThatWeCan;
            }
            this.balance -= amount;
            return amount;
        }

        public override string ToString()
        {
            return "balance: " + this.balance + ", space left " + HowMuchSpaceLeft();
        }
    }
}

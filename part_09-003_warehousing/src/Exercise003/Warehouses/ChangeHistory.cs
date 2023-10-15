namespace Exercise003
{
    public class ChangeHistory
    {
        private List<int> history;
        public ChangeHistory()
        {
            this.history = new List<int>();
        }

        public void Add(int status)
        {
            this.history.Add(status);
        }
        public void Clear()
        {
            this.history.Clear();
        }
        public int MaxValue()
        {
            return this.history.Max();
        }
        public int MinValue()
        {
            return this.history.Min();
        }

        public override string ToString()
        {
            int lastIndex = this.history.Count - 1;
            return "Current: " + this.history[lastIndex] + " Min: " + MinValue() + " Max: " + MaxValue();
        }
    }
}
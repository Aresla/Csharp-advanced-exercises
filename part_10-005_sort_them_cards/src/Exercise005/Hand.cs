namespace Exercise005
{
    using System;

    public class Hand
    {
        private List<Card> list;

        public Hand()
        {
            this.list = new List<Card>();
        }

        public void Add(Card card)
        {
            foreach (Card item in this.list)
            {
                if (item.Equals(card))
                {
                    break;
                }
                else
                {
                    this.list.Add(card);
                }
            }
        }

        public void Print()
        {
            foreach (Card item in this.list)
            {
                item.ToString();
            }
        }
    }
}
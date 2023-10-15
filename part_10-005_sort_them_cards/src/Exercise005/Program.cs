namespace Exercise005
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Hand hand = new Hand();

            hand.Add(new Card(2, Suit.Diamond));
            hand.Add(new Card(14, Suit.Spade));
            hand.Add(new Card(12, Suit.Heart));
            hand.Add(new Card(2, Suit.Spade));

            hand.Print();
        }
    }
}
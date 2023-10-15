namespace Exercise005
{
    using System;
    public class Card : IComparable<Card>
    {
        public int value { get; }
        public Suit suit { get; }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            if (this.value == 14)
            {
                return $"{this.suit} A";
            }
            if (this.value == 13)
            {
                return $"{this.suit} K";
            }
            if (this.value == 12)
            {
                return $"{this.suit} Q";
            }
            if (this.value == 11)
            {
                return $"{this.suit} J";
            }
            return $"{this.suit} {this.value}";

        }

        public int CompareTo(Card another)
        {
            if (another == null)
            {
                return 1;
            }
            // If value is equal, return 0
            // They are now equal in comparison
            if (this.value == another.value && this.suit > another.suit)
            {
                return 1;
            }
            if (this.value == another.value && this.suit < another.suit)
            {
                return -1;
            }
            if (this.value == another.value && this.suit == another.suit)
            {
                return 0;
            }
            // If this height is more
            // Return 1
            // "this" comes after compared member
            else if (this.value > another.value)
            {
                return 1;
            }
            // As all other options have been done
            // Return -1
            // "this" comes before compared member
            else
            {
                return -1;
            }
        }


        public override bool Equals(object compared)
        {
            // if the variables are located in the same position, they are equal
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type Card, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                // convert the object to a Card object
                Card comparedCard = (Card)compared;

                // if the values of the object variables are equal, the objects are, too
                return this.value == comparedCard.value && this.suit == comparedCard.suit;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.value, this.suit.GetHashCode());
        }

    }
}
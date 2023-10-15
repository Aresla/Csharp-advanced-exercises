namespace Exercise006
{
    using System;
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        public bool Earlier(SimpleDate compared)
        {
            if (this.year < compared.year)
            {
                return true;
            }
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type SimpleDate, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                // convert the object to a SimpleDate object
                SimpleDate comparedSimpleDate = (SimpleDate)compared;

                // if the values of the object variables are equal, the objects are, too
                return this.day == comparedSimpleDate.day && this.month == comparedSimpleDate.month && this.year == comparedSimpleDate.year;
            }
        }
        public override int GetHashCode()
        {
            if (this.day == null)
            {
                if (this.month == null)
                {
                    return this.year + this.month.GetHashCode(); ;
                }
                return this.month;
            }

            return this.year + this.day.GetHashCode();

        }
    }
}

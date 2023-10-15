namespace Exercise007
{
    using System;
    public class LicensePlate
    {
        public string liNumber { get; }
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }


        public override string ToString()
        {
            return country + " " + liNumber;
        }

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


            LicensePlate comparedLicensePlate = (LicensePlate)compared;


            return this.country == comparedLicensePlate.country &&
                this.liNumber == comparedLicensePlate.liNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.country, this.liNumber);
        }

    }
}

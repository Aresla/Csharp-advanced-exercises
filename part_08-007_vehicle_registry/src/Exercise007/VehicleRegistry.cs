namespace Exercise007
{
    using System;
    using System.Collections.Generic;
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> register;

        public VehicleRegistry()
        {
            this.register = new Dictionary<LicensePlate, string>();
        }

        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (!this.register.ContainsKey(licensePlate))
            {
                this.register.Add(licensePlate, owner);
                return true;
            }
            return false;
        }
        public string Get(LicensePlate licensePlate)
        {
            if (this.register.ContainsKey(licensePlate))
            {
                return this.register[licensePlate];
            }
            else
            {
                return "not registered";
            }
        }
        public bool Remove(LicensePlate licensePlate)
        {
            if (this.register.ContainsKey(licensePlate))
            {
                this.register.Remove(licensePlate);
                return true;
            }
            return false;
        }
        public void PrintLicensePlates()
        {
            Dictionary<LicensePlate, string>.KeyCollection keys = this.register.Keys;
            foreach (LicensePlate licensePlate in keys)
            {

                Console.WriteLine(licensePlate);
            }
        }
        public void PrintOwners()
        {
            Dictionary<LicensePlate, string>.ValueCollection values = this.register.Values;
            List<string> listOfUniqOwners = new List<string>();
            foreach (string owner in values)
            {
                if (!listOfUniqOwners.Contains(owner))
                    Console.WriteLine(owner);
                listOfUniqOwners.Add(owner);
            }
        }
    }
}

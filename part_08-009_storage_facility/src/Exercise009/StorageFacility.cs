namespace Exercise009
{
    using System;
    using System.Collections.Generic;

    public class StorageFacility
    {
        private Dictionary<string, List<string>> storageForGoods;
        public StorageFacility()
        {
            this.storageForGoods = new Dictionary<string, List<string>>();
        }

        public void Add(string unit, string item)
        {
            if (!this.storageForGoods.ContainsKey(unit))
            {
                this.storageForGoods.Add(unit, new List<string>());
            }
            this.storageForGoods[unit].Add(item);
        }

        public List<string> Contents(string storageUnit)
        {
            if (this.storageForGoods.ContainsKey(storageUnit))
            {
                return this.storageForGoods[storageUnit];
            }
            else
            {
                return new List<string>();
            }
        }

        public void Remove(string storageUnit, string item)
        {
            if (this.storageForGoods.ContainsKey(storageUnit))
            {
                this.storageForGoods[storageUnit].Remove(item);
            }
        }


        public List<string> StorageUnits()
        {
            List<string> units = new List<string>();
            foreach (var unit in this.storageForGoods.Keys)
            {
                if (this.storageForGoods[unit].Count != 0)
                {
                    units.Add(unit);
                }
            }
            return units;
        }
    }
}
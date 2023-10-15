namespace Exercise005
{
    using System;
    using System.Collections.Generic;
    public class IOU
    {
        private Dictionary<string, int> listIOU;

        public IOU()
        {
            this.listIOU = new Dictionary<string, int>();
        }

        public void ChangeDebt(string toWhom, int amount)
        {
            if (this.listIOU.ContainsKey(toWhom))
            {
                if ((this.listIOU[toWhom] + amount) >= 0)
                {
                    this.listIOU[toWhom] += amount;
                }
                else
                {
                    this.listIOU[toWhom] = 0;
                }
            }
            else
            {
                if (amount > 0)
                {
                    this.listIOU.Add(toWhom, amount);
                }
                else
                {
                    this.listIOU.Add(toWhom, 0);
                }
            }
        }

        public int HowMuchDoIOweTo(string toWhom)
        {
            if (this.listIOU.ContainsKey(toWhom))
            {
                return this.listIOU[toWhom];
            }
            else
            {
                return 0;
            }
        }

    }
}
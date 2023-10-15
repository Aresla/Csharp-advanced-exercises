namespace Exercise005
{
    using System;
    public class TripleTacoBox : ITacoBox
    {
        public int tacos { get; set; }

        public TripleTacoBox()
        {
            this.tacos = 3;
        }

        public int TacosRemaining()
        {
            return this.tacos;
        }

        public void Eat()
        {
            if (this.tacos == 0)
            {
                this.tacos = 0;
            }
            else
            {
                this.tacos--;
            }
        }
    }
}
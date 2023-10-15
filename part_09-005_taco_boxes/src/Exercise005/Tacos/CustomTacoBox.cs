namespace Exercise005
{
    using System;
    public class CustomTacoBox : ITacoBox
    {
        public int tacos { get; set; }
        public CustomTacoBox(int tacos)
        {
            this.tacos = tacos;
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
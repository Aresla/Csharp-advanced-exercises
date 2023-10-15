namespace Exercise004
{
    using System;

    public class StandardSensor : ISensor
    {
        public int sensorValue { get; }

        public StandardSensor(int number)
        {
            this.sensorValue = number;
        }

        public int Read()
        {
            return this.sensorValue;
        }

        public void SetOn()
        { }
        public void SetOff()
        { }
        public bool IsOn()
        {
            return true;
        }
    }
}
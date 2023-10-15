namespace Exercise004
{
    using System;
    public class TemperatureSensor : ISensor
    {
        public int sensorValue { get; }
        public bool sensor;
        public TemperatureSensor()
        {
            this.sensor = false;
        }

        // returns true if the sensor is on
        public bool IsOn()
        {
            if (this.sensor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // sets the sensor on
        public void SetOn()
        {
            this.sensor = true;
        }
        // sets the sensor off    
        public void SetOff()
        {
            this.sensor = false;
        }
        // returns the value of the sensor if it's on
        // if the sensor is not on throw a IllegalStateException
        public int Read()
        {
            if (this.sensor)
            {
                Random random = new Random();
                int randomNumber = random.Next(-30, 31);
                return randomNumber;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }
}
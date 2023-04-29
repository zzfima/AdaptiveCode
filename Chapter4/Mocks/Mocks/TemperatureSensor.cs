namespace Sensor
{
    internal class TemperatureSensor : ISensor
    {
        public TemperatureSensor(int bitrate, int port)
        {

        }

        public string DoOperation(string input)
        {
            //send some to HW
            //wait for answer
            //return answer
            return "23 C";

        }

        public void Initialize()
        {
            //connect to sensor HW
        }
    }
}

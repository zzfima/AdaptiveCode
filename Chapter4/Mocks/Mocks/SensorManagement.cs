using Sensor;

namespace Sensors
{
    public class SensorManagement : ISensorManagement
    {
        private readonly IList<ISensor> _sensors;
        public SensorManagement()
        {
            _sensors = new List<ISensor>();
        }
        public void AddSensor(ISensor sensor)
        {
            _sensors.Add(sensor);
        }

        public double GetAverage()
        {
            return _sensors.Average(s => s.MeasureTemperature());
        }
    }
}

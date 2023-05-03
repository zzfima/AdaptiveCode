using Sensor;

namespace Sensors
{
    public interface ISensorManagement
    {
        void AddSensor(ISensor sensor);
        double GetAverage();

    }
}
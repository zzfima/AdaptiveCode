namespace Sensor
{
    public interface ISensor
    {
        string DoOperation(string input);
        void Initialize();
    }
}
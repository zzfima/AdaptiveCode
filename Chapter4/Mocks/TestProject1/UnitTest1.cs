using Moq;
using Sensor;
using Sensors;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Mock<ISensor>? sensor1 = new Mock<ISensor>();
            Mock<ISensor>? sensor2 = new Mock<ISensor>();
            Mock<ISensor>? sensor3 = new Mock<ISensor>();

            sensor1.Setup(s => s.MeasureTemperature()).Returns(4.5);
            sensor2.Setup(s => s.MeasureTemperature()).Returns(4.5);
            sensor3.Setup(s => s.MeasureTemperature()).Returns(4.5);

            var sensorMng = new SensorManagement();

            sensorMng.AddSensor(sensor1.Object);
            sensorMng.AddSensor(sensor2.Object);
            sensorMng.AddSensor(sensor3.Object);

            Assert.AreEqual(sensorMng.GetAverage(), 4.5, 0.1);
        }
    }
}
using Moq;
using Sensor;
using System.Resources;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<ISensor>? _deviceMocked;
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_deviceMocked?.Object.DoOperation("a"), "aaa");
            Assert.AreEqual(_deviceMocked?.Object.DoOperation("b"), "bbb");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _deviceMocked = new Mock<ISensor>();
            _deviceMocked.Setup(d => d.DoOperation("a")).Returns("aaa");
            _deviceMocked.Setup(d => d.DoOperation("b")).Returns("bbb");
        }
    }
}
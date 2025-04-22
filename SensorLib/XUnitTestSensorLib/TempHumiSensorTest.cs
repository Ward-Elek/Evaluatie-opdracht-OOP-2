using SensorLib;
using Xunit;

namespace XUnitTestSensorLib
{
    public class TempHumiSensorTest
    {
        [Fact]
        public void Properties_Werken()
        {
            var sensor = new TempHumiSensor
            {
                TempValue = 22.5,
                HumiValue = 55
            };

            Assert.Equal(22.5, sensor.TempValue);
            Assert.Equal(55, sensor.HumiValue);
        }

        [Fact]
        public void ToJson_Werkt()
        {
            var sensor = new TempHumiSensor
            {
                Name = "TempSensor1",
                TempValue = 21.1,
                HumiValue = 48.5
            };

            string json = sensor.ToJsonString();
            Assert.Contains("\"TempValue\":21.1", json);
            Assert.Contains("\"HumiValue\":48.5", json);
        }
    }
}

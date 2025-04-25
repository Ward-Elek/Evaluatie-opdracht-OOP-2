using SensorLib;

namespace XUnitTestSensorLib
{
    public class UVSensorTest
    {
        [Fact]
        public void IsOK_GeeftTrue()
        {
            var sensor = new UVSensor { Value = 7.5, LowLevel = 5 };
            Assert.True(sensor.IsOK());
        }

        [Fact]
        public void IsOK_GeeftFalse()
        {
            var sensor = new UVSensor { Value = 3, LowLevel = 5 };
            Assert.False(sensor.IsOK());
        }

        [Fact]
        public void ToJson_Werkt()
        {
            var sensor = new UVSensor
            {
                Name = "UV-A",
                Location = "Top",
                Type = "UV",
                Value = 8,
                LowLevel = 5
            };

            string json = sensor.ToJsonString();

            Assert.Contains("\"Name\":\"UV-A\"", json);
            Assert.Contains("\"LowLevel\":5", json);
        }
    }
}

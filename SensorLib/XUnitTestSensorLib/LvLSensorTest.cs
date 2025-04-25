using SensorLib;

namespace XUnitTestSensorLib
{
    public class LvLSensorTest
    {
        [Fact]
        public void IsFull_Werkt()
        {
            var sensor = new LevelSensor { Value = 90, HighLevel = 80 };
            Assert.True(sensor.IsFull());
        }

        [Fact]
        public void IsEmpty_Werkt()
        {
            var sensor = new LevelSensor { Value = 10, LowLevel = 20 };
            Assert.True(sensor.IsEmpty());
        }

        [Fact]
        public void ToJson_Werkt()
        {
            var sensor = new LevelSensor
            {
                Name = "Level A",
                Location = "Zone 1",
                Type = "Level",
                Value = 50,
                LowLevel = 20,
                HighLevel = 80
            };

            string json = sensor.ToJsonString();

            Assert.Contains("\"Name\":\"Level A\"", json);
            Assert.Contains("\"Value\":50", json);
        }
    }
}

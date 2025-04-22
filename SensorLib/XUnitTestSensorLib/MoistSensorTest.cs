using SensorLib;
using Xunit;

namespace XUnitTestSensorLib
{
    public class MoistSensorTest
    {
        [Fact]
        public void Properties_Werken()
        {
            var sensor = new MoistureSensor
            {
                Name = "Moisture A",
                Location = "Bed 2",
                Type = "Moisture",
                Value = 33.5,
                Depth = 12
            };

            Assert.Equal("Moisture A", sensor.Name);
            Assert.Equal(12, sensor.Depth);
        }

        [Fact]
        public void ToJson_Werkt()
        {
            var sensor = new MoistureSensor { Name = "SensorX", Value = 44.4, Depth = 15 };
            string json = sensor.ToJsonString();

            Assert.Contains("\"Depth\":15", json);
            Assert.Contains("\"Value\":44.4", json);
        }
    }
}

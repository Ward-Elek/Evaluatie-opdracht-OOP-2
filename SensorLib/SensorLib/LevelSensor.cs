using System.Text.Json;

namespace SensorLib
{
    public class LevelSensor : ILevel
    {
        // Properties uit ISensor
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }

        // Properties uit ILevel
        public double Value { get; set; }
        public double LowLevel { get; set; }
        public double HighLevel { get; set; }

        // Methodes
        public bool IsFull()
        {
            return Value >= HighLevel;
        }


        public bool IsEmpty()
        {
            return Value <= LowLevel;
        }

        // Zet volledige object om in JSON string 
        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

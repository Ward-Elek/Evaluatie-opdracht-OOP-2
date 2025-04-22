using System.Text.Json;

namespace SensorLib
{
    public class UVSensor : IUVlight
    {
        // Properties uit ISensor
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }

        // Properties uit IUVlight
        public double Value { get; set; }
        public double LowLevel { get; set; }

        // Methode
        public bool IsOK()
        {
            return Value >= LowLevel;
        }

        // Zet volledige object om in JSON string 
        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}


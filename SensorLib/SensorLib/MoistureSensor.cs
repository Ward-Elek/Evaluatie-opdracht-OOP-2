using System.Text.Json;

namespace SensorLib
{
    public class MoistureSensor : IMoisture
    {
        // Properties uit ISensor
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }

        // Properties uit IMoisture
        public double Value { get; set; }
        public double Depth { get; set; }

        // Methode
        // Zet volledige object om in JSON string 
        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

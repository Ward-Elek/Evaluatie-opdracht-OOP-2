using System.Text.Json;

namespace SensorLib
{
    public class TempHumiSensor : ITempHumi
    {
        // Properties uit ISensor
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }

        // Properties uit ITempHumi
        public double TempValue { get; set; }
        public double HumiValue { get; set; }

        //Methode
        // Zet volledige object om in JSON string 
        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

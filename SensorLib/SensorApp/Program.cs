using SensorLib;
using System;
using System.Collections.Generic;

namespace SensorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GREENHOUSE SENSOREN – JSON OVERZICHT\n");

            // Lijst van sensoren aanmaken
            List<ISensor> sensors = new List<ISensor>
            {
                new LevelSensor
                {
                    Name = "WaterTank",
                    Location = "Zone A",
                    Type = "Level",
                    Value = 70,
                    LowLevel = 20,
                    HighLevel = 80
                },
                new MoistureSensor
                {
                    Name = "Bodemvocht 1",
                    Location = "Bed 3",
                    Type = "Moisture",
                    Value = 45.6,
                    Depth = 10
                },
                new TempHumiSensor
                {
                    Name = "KlimaatSensor",
                    Location = "Kas 2",
                    Type = "TempHumi",
                    TempValue = 22.5,
                    HumiValue = 55
                },
                new UVSensor
                {
                    Name = "UV-A Sensor",
                    Location = "Dak",
                    Type = "UV",
                    Value = 9,
                    LowLevel = 5
                }
            };

            // JSON tonen per sensor
            foreach (var sensor in sensors)
            {
                Console.WriteLine(sensor.ToJsonString());
                Console.WriteLine(); 
            }

            Console.WriteLine("Klaar. Druk toets om af te sluiten...");
            Console.ReadKey();
        }
    }
}

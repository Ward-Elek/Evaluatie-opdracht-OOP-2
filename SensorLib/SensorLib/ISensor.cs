namespace SensorLib
{
    public interface ISensor
    {
        //Properties
        string Name { get; set; }
        string Location { get; set; }
        string Type { get; set; }

        //Methode
        string ToJsonString();
    }
}

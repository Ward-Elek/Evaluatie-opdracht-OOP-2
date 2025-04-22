namespace SensorLib
{
    public interface IMoisture : ISensor
    {
        //Properties
        double Value { get; set; }
        double Depth { get; set; }
    }
}

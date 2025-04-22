namespace SensorLib
{
    public interface ITempHumi : ISensor
    {
        //properties
        double TempValue { get; set; }
        double HumiValue { get; set; }
    }
}

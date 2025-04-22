namespace SensorLib
{
    public interface ILevel : ISensor
    {
        //properties
        double Value { get; set; }
        double LowLevel { get; set; }
        double HighLevel { get; set; }

        //methodes
        bool IsFull();
        bool IsEmpty();
    }
}

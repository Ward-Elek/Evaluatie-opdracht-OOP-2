namespace SensorLib
{
    public interface IUVlight : ISensor
    {
        //Properties
        double Value { get; set; }
        double LowLevel { get; set; }

        //Methode
        bool IsOK();
    }
}

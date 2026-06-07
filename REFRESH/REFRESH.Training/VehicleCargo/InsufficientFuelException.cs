namespace REFRESH.Training.VehicleCargo;
public class InsufficientFuelException : Exception
{
    public InsufficientFuelException(double has, double required)
        : base($"Insufficient fuel level for a ride. Has: {has}, required: {required}") { }
    public InsufficientFuelException(string message) : base(message) { }
}

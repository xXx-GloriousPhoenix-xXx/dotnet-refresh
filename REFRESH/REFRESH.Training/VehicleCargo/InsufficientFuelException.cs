namespace REFRESH.Training.VehicleCargo;
public class InsufficientFuelException(double has, double required)
    : Exception($"Insufficient fuel level for a ride. Has: {has}, required: {required}") {}

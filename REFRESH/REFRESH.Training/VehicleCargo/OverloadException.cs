namespace REFRESH.Training.VehicleCargo;
public class OverloadException(double exceedValueInKg)
    : Exception($"The cargo exceeds the maximum lifting capacity by {exceedValueInKg} kgs")
{
}

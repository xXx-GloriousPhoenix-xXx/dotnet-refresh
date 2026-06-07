namespace REFRESH.Training.VehicleCargo;

public class AirConditionedTruck(Truck truck) : IVehicle
{
    private readonly Truck _truck = truck;
    public void Drive(int km)
    {
        Console.WriteLine("Air conditioner starts working");
        _truck.Drive(km);
        Console.WriteLine("Air conditioner stops working");
    }
}

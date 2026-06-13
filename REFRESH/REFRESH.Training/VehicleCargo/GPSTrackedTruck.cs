namespace REFRESH.Training.VehicleCargo;

public class GPSTrackedTruck(Truck truck) : IVehicle
{
    private readonly Truck _truck = truck;
    public void Drive(int km)
    {
        Console.WriteLine("GPS navigator starts showing the way");
        _truck.Drive(km);
        Console.WriteLine("GPS navigator stops showing the way");
    }
}

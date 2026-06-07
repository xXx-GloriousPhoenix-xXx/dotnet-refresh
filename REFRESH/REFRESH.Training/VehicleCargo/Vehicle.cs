namespace REFRESH.Training.VehicleCargo;
public class Vehicle(string brand, double tankCapacity, double fuelConsumptionPerKm)
{
    protected readonly string _brand = brand;
    protected readonly double _tankCapacity = tankCapacity;
    protected double _fuelLevel = 0D;
    protected readonly double _fuelConsumptionPerKm = fuelConsumptionPerKm;
    protected int _kmDriven = 0;

    /// <summary>
    /// Refuels car tank
    /// </summary>
    /// <param name="amount">Amount of fuel to pour in</param>
    /// <returns>The amount of extra fuel</returns>
    public double Refuel(double amount)
    {
        var tmp = _fuelLevel + amount;
        if (tmp > _tankCapacity)
        {
            _fuelLevel = _tankCapacity;
            return tmp - _tankCapacity;
        }
        else
        {
            _fuelLevel += amount;
            return 0;
        }
    }

    /// <summary>
    /// Spends fuel to drive
    /// </summary>
    /// <param name="km">Distance in km to drive</param>
    /// <exception cref="InsufficientFuelException">Throws exception in case of insufficient fuel for a ride</exception>
    public virtual void Drive(int km)
    {
        var fuelRequired = km * _fuelConsumptionPerKm;
        if (fuelRequired > _fuelLevel)
        {
            throw new InsufficientFuelException(_fuelLevel, fuelRequired);
        }
        else
        {
            _fuelLevel -= fuelRequired;
            _kmDriven += km;
        }
    }
}

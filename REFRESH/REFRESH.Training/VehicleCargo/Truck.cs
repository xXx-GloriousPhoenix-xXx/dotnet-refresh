namespace REFRESH.Training.VehicleCargo;

public sealed class Truck(
    string brand, double tankCapacity, double fuelConsumptionPerKm,
    double maxCargoWeightInKg, double extraConsumptionPerKg)
    : Vehicle(brand, tankCapacity, fuelConsumptionPerKm)
{
    private readonly double _maxCargoWeightInKg = maxCargoWeightInKg;
    private readonly double _extraConsumptionPerKg = extraConsumptionPerKg;
    private readonly List<Cargo> _storage = [];
    public double TotalCargoWeightInKg => _storage.Sum(c => c.WeightInKg);
    public double AvailableCargoWeightInKg => _maxCargoWeightInKg - TotalCargoWeightInKg;

    /// <summary>
    /// Adds cargo to the vehicle storage
    /// </summary>
    /// <param name="cargo">Cargo object to add</param>
    /// <exception cref="OverloadException">Throws exception if cargo's weight is greater than available</exception>
    public void Load(Cargo cargo)
    {
        if (AvailableCargoWeightInKg < cargo.WeightInKg)
        {
            throw new OverloadException(AvailableCargoWeightInKg - cargo.WeightInKg);
        }

        _storage.Add(cargo);
    }

    /// <summary>
    /// Removes crago from the vehicle storage
    /// </summary>
    /// <param name="cargo"></param>
    /// <exception cref="InvalidOperationException">Throws exception if cargo is not present in storage</exception>
    public void Unload(Cargo cargo)
    {
        if (!_storage.Contains(cargo))
        {
            throw new InvalidOperationException("Cargo is not present in storage");
        }

        _storage.Remove(cargo);
    }

    /// <summary>
    /// Carries cargo on given distance in km
    /// </summary>
    /// <param name="km"></param>
    /// <exception cref="InsufficientFuelException">Throws exception in case of insufficient fuel for a ride</exception>
    public override void Drive(int km)
    {
        var requiredFuel = km * (_fuelConsumptionPerKm + _extraConsumptionPerKg * TotalCargoWeightInKg);
        if (requiredFuel > _fuelLevel)
        {
            throw new InsufficientFuelException(_fuelLevel, requiredFuel);
        }

        _kmDriven += km;
        _fuelLevel -= requiredFuel;
    }
}
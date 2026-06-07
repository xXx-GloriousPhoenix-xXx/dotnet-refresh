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
    private const int TIME_IN_MS_PER_KM = 100;

    /// <summary>
    /// Returns required amount of fuel for a ride
    /// </summary>
    /// <param name="distanceKm">Distance of ride in km</param>
    /// <returns>Required amount of fuel for a ride</returns>
    public double GetRequiredFuel(int distanceKm)
    {
        return distanceKm * (_fuelConsumptionPerKm + _extraConsumptionPerKg * TotalCargoWeightInKg);
    }

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
    /// Loads cargo in case of sufficient space
    /// </summary>
    /// <param name="cargoList">List of cargo</param>
    /// <returns>List on unloaded cargo</returns>
    /// <exception cref="InvalidOperationException">Throws exception if cargo list is empty</exception>
    public IEnumerable<Cargo> Load(IList<Cargo> cargoList)
    {
        if (cargoList.Count == 0)
        {
            throw new InvalidOperationException("Cargo list is empty");
        }

        var i = 0;
        var skippedCargo = new List<Cargo>();
        while (i < cargoList.Count)
        {
            if (AvailableCargoWeightInKg < cargoList[i].WeightInKg)
            {
                skippedCargo.Add(cargoList[i++]);
            }
            else
            {
                _storage.Add(cargoList[i]);
            }
        }

        return skippedCargo;
    }

    /// <summary>
    /// Removes crago from the vehicle storage
    /// </summary>
    /// <param name="cargo"></param>
    /// <exception cref="InvalidOperationException">Throws exception if cargo is not present in storage</exception>
    public bool Unload(Cargo cargo)
    {
        if (!_storage.Contains(cargo))
        {
            throw new InvalidOperationException("Cargo is not present in storage");
        }

        return _storage.Remove(cargo);
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

    /// <summary>
    /// Performs delivery asynchronously
    /// </summary>
    /// <param name="distanceKm">Distance of delivery in km</param>
    /// <param name="ct">Token to cancel delivery</param>
    /// <returns></returns>
    /// <exception cref="InsufficientFuelException">Throws exception if delivery is failed</exception>
    public async Task DeliverAsync(int distanceKm, CancellationToken ct = default)
    {
        var requiredFuel = GetRequiredFuel(distanceKm);
        if (requiredFuel > _fuelLevel)
        {
            throw new InsufficientFuelException(_fuelLevel, requiredFuel);
        }

        var totalDrivenInKm = 0;
        try
        {
            for (var i = 0; i < distanceKm; i++)
            {
                ct.ThrowIfCancellationRequested();

                await Task.Delay(TIME_IN_MS_PER_KM, ct);
                Drive(1);
                totalDrivenInKm += 1;
            }

            _kmDriven += distanceKm;
        }
        catch (OperationCanceledException)
        {
            _kmDriven += 2 * totalDrivenInKm;
        }
    }
}
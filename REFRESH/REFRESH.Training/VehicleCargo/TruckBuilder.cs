namespace REFRESH.Training.VehicleCargo;
public class TruckBuilder
{
    private string _brand = "MAN";
    private double _tankCapacity = 500D;
    private double _fuelConsumptionPerKm = 4D;
    private int _maxCargoWeightInKg = 150_000;
    private double _extraConsumptionPerKg = 0.03D;

    public TruckBuilder SetBrand(string brand)
    {
        _brand = brand;
        return this;
    }

    public TruckBuilder SetTankCapacity(double tankCapacity)
    {
        _tankCapacity = tankCapacity;
        return this;
    }

    public TruckBuilder SetFuelConsumptionPerKm(double fuelConsumptionPerKm)
    {
        _fuelConsumptionPerKm = fuelConsumptionPerKm;
        return this;
    }

    public TruckBuilder SetMaxCargoWeightInKg(int maxCargoWeightInKg)
    {
        _maxCargoWeightInKg = maxCargoWeightInKg;
        return this;
    }

    public TruckBuilder SetExtraConsumptionPerKg(double extraConsumptionPerKg)
    {
        _extraConsumptionPerKg = extraConsumptionPerKg;
        return this;
    }

    public Truck Build()
    {
        return new Truck(_brand, _tankCapacity, _fuelConsumptionPerKm, _maxCargoWeightInKg, _extraConsumptionPerKg);
    }
}

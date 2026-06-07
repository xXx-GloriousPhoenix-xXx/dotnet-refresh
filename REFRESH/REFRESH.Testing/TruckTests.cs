using FluentAssertions;
using REFRESH.Training.VehicleCargo;

namespace REFRESH.Testing;
public class TruckTests
{
    #region LoadTests
    [Fact]
    public void LoadSingleCargo_WithValidWeight_AddsToStorage()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var cargoWeight = 1000D;
        var cargo = new Cargo(cargoWeight);

        // Act
        truck.Load(cargo);

        // Assert
        Assert.Equal(cargoWeight, truck.TotalCargoWeightInKg);
    }

    [Fact]
    public void LoadSingleCargo_WithOverweight_ThrowsOverloadException()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var cargo = new Cargo(200_000D);

        // Act
        var act = () => truck.Load(cargo);

        // Assert
        act.Should().Throw<OverloadException>();
    }

    [Fact]
    public void LoadMultipleCargo_WithExceedingWeight_AddsOnlyFittingCargo()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var testingWeight = 145_000D;
        var extraCargo = new Cargo(100_000D);
        var cargoList = new List<Cargo>()
        {
            new (50_000D),
            new (75_000D),
            extraCargo,
            new(20_000D)
        };

        // Act
        var extraCargoList = truck.Load(cargoList);

        // Assert
        Assert.Single(extraCargoList);
        Assert.Equal(testingWeight, truck.TotalCargoWeightInKg);
    }

    [Fact]
    public void LoadMultipleCargo_WithEmptyArray_ThrowsInvalidOperationException()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var cargoList = new List<Cargo>();

        // Act
        var act = () => truck.Load(cargoList);

        // Assert
        act.Should().Throw<InvalidOperationException>();
    }
    #endregion

    #region UnloadTests
    [Fact]
    public void UnloadCargo_WithExistingCargo_ReturnsTrue()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var cargo = new Cargo(1000D);

        // Act
        truck.Load(cargo);
        var result = truck.Unload(cargo);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void UnloadCargo_WithInexistingCargo_ThrowsInvalidOperationException()
    {
        // Arrange
        var truck = new Truck("MAN", 500D, 2D, 150_000, 0.8D);
        var cargo = new Cargo(1000D);

        // Act
        var act = () => truck.Unload(cargo);

        // Assert
        act.Should().Throw<InvalidOperationException>();
    }
    #endregion

    #region DriveTests
    [Fact]
    public void Drive_WithSufficientFuel_DecreasesFuelLevelAndIncreasesKm()
    {
        // Arrange
        var cargoWeight = 1_000D;
        var fuelConsumptionPerKm = 4D;
        var extraConsumptionPerKg = 0.03D;
        var distanceKm = 3;
        var testFuelSpent = distanceKm * (fuelConsumptionPerKm + extraConsumptionPerKg * cargoWeight);
        var remainingFuel = 10;
        var initialFuel = testFuelSpent + remainingFuel;

        var truck = new Truck("MAN", 500D, fuelConsumptionPerKm, 150_000, extraConsumptionPerKg);
        truck.Load(new Cargo(cargoWeight));
        truck.Refuel(initialFuel);

        // Act
        truck.Drive(distanceKm);

        // Assert
        Assert.Equal(distanceKm, truck.KmDriven);
        Assert.Equal(remainingFuel, truck.FuelLevel);
    }

    [Fact]
    public void Drive_WithInsufficientFuel_ThrowsInsufficientFuelException()
    {
        // Arrange
        var cargoWeight = 1_000D;
        var fuelConsumptionPerKm = 4D;
        var extraConsumptionPerKg = 0.03D;
        var distanceKm = 3;
        var testFuelSpent = distanceKm * (fuelConsumptionPerKm + extraConsumptionPerKg * cargoWeight);
        var insufficientFuel = 10;
        var initialFuel = testFuelSpent - insufficientFuel;

        var truck = new Truck("MAN", 500D, fuelConsumptionPerKm, 150_000, extraConsumptionPerKg);
        truck.Load(new Cargo(cargoWeight));
        truck.Refuel(initialFuel);

        // Act
        var act = () => truck.Drive(distanceKm);

        // Assert
        act.Should().Throw<InsufficientFuelException>();
    }
    #endregion
}

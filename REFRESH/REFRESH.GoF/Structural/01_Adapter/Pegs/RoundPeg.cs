namespace REFRESH.GoF.Structural._01_Adapter.Pegs;

public class RoundPeg(double radius)
{
    private readonly double _radius = radius;
    public double GetRadius() => _radius;
}

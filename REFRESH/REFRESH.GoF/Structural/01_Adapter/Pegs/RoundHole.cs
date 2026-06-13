namespace REFRESH.GoF.Structural._01_Adapter.Pegs;
public class RoundHole(double radius)
{
    private readonly double _radius = radius;
    public double GetRadius() => _radius;
    public bool Fits(RoundPeg peg) => peg.GetRadius() <= _radius;
}

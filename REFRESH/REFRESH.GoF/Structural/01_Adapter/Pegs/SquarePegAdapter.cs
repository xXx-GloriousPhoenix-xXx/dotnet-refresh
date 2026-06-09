namespace REFRESH.GoF.Structural._01_Adapter.Pegs;

public class SquarePegAdapter(SquarePeg peg)
{
    private readonly SquarePeg _peg = peg;
    public double GetRadius() => _peg.GetWidth() * Math.Sqrt(2) / 2;
}
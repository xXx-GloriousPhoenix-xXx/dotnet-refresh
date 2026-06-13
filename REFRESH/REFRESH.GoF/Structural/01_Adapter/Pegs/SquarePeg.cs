namespace REFRESH.GoF.Structural._01_Adapter.Pegs;

public class SquarePeg(double width)
{
    private readonly double _width = width;
    public double GetWidth() => _width;
}

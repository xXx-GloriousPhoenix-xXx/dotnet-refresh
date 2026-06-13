namespace REFRESH.GoF.Behavioral._08_Strategy;

public class PublicTransportStrategy : IRouteStrategy
{
    public int IntermediateDots => 15;

    public RouteNode BuildRoute(RouteNode a, RouteNode b)
    {
        var (x0, y0) = (a.Position.X, a.Position.Y);
        var (x1, y1) = (b.Position.X, b.Position.Y);

        var xm = (x0 + x1) / 2f;
        var ym = (y0 + y1) / 2f;

        var rhs0 = y0 - x0 * x0 * x0;
        var rhsm = ym - xm * xm * xm;
        var rhs1 = y1 - x1 * x1 * x1;

        var (coefA, coefB, coefC) = SolveGauss(
            x0 * x0, x0, 1, rhs0,
            xm * xm, xm, 1, rhsm,
            x1 * x1, x1, 1, rhs1);

        float function(float x) =>
            x * x * x + coefA * x * x + coefB * x + coefC;

        return BuildChain(a, b, function, IntermediateDots);
    }

    private static (float x, float y, float z) SolveGauss(
        float a1, float b1, float c1, float d1,
        float a2, float b2, float c2, float d2,
        float a3, float b3, float c3, float d3)
    {
        float[,] m =
        {
            { a1, b1, c1, d1 },
            { a2, b2, c2, d2 },
            { a3, b3, c3, d3 }
        };

        const int n = 3;

        for (var col = 0; col < n; col++)
        {
            var pivotRow = col;
            for (var row = col + 1; row < n; row++)
                if (Math.Abs(m[row, col]) > Math.Abs(m[pivotRow, col]))
                    pivotRow = row;

            if (pivotRow != col)
                for (var k = 0; k <= n; k++)
                    (m[col, k], m[pivotRow, k]) = (m[pivotRow, k], m[col, k]);

            for (var row = col + 1; row < n; row++)
            {
                var factor = m[row, col] / m[col, col];
                for (var k = col; k <= n; k++)
                    m[row, k] -= factor * m[col, k];
            }
        }

        var result = new float[n];
        for (var row = n - 1; row >= 0; row--)
        {
            result[row] = m[row, n];
            for (var k = row + 1; k < n; k++)
                result[row] -= m[row, k] * result[k];
            result[row] /= m[row, row];
        }

        return (result[0], result[1], result[2]);
    }

    private static RouteNode BuildChain(
        RouteNode a, RouteNode b,
        Func<float, float> function,
        int intermediateDots)
    {
        var x0 = a.Position.X;
        var x1 = b.Position.X;
        var step = (x1 - x0) / (intermediateDots + 1);

        var curr = a;
        for (var i = 1; i <= intermediateDots; i++)
        {
            var x = x0 + step * i;
            var y = function(x);
            var node = new RouteNode(x, y);
            curr.Next = node;
            curr = node;
        }
        curr.Next = b;

        return a;
    }
}
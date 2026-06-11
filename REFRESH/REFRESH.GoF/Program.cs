using REFRESH.GoF.Structural._06_Flyweight;

var canvas = new Canvas();

var u1 = new Unit(new(0, 0));
var u2 = new Unit(new(500, 500));

u1.FireAt(u2);

foreach (var movingParticle in Game.MPS)
{
    movingParticle.Move();
}

u2.FireAt(u1);

foreach (var movingParticle in Game.MPS)
{
    movingParticle.Move();
}

Game.Draw(canvas);
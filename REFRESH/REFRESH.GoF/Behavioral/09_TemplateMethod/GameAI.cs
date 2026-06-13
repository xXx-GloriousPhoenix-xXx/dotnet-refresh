using System.Numerics;

namespace REFRESH.GoF.Behavioral._09_TemplateMethod;
public abstract class GameAI
{
    protected readonly List<Structure> _builtStructures = [];
    public void TakeTurn()
    {
        CollectResources();
        BuildStructures();
        BuildUnits();
        Attack();
    }
    public virtual void CollectResources()
    {
        foreach (var s in _builtStructures)
        {
            s.Collect();
        }
    }
    public abstract void BuildStructures();
    public abstract void BuildUnits();
    public virtual void Attack()
    {
        var enemy = ClosestEnemy();
        if (enemy is null)
        {
            SendScouts(Vector2.Zero);
        }
        else
        {
            SendWarriors(enemy.Position);
        }
    }
    public abstract void SendScouts(Vector2 position);
    public abstract void SendWarriors(Vector2 position);
    public Enemy? ClosestEnemy() => new();
}

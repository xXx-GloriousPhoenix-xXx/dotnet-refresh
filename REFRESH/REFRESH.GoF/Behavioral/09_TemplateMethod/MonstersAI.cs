using System.Numerics;

namespace REFRESH.GoF.Behavioral._09_TemplateMethod;

public class MonstersAI : GameAI
{
    public override void CollectResources()
    {
        // Do nothing
    }
    public override void BuildStructures()
    {
        // Do nothing
    }
    public override void BuildUnits()
    {
        // Do nothing
    }

    public override void SendScouts(Vector2 position)
    {
        // Do nothing
    }

    public override void SendWarriors(Vector2 position)
    {
        // Do nothing
    }
}

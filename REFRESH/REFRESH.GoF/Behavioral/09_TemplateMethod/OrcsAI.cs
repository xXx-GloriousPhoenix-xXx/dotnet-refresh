using System.Numerics;

namespace REFRESH.GoF.Behavioral._09_TemplateMethod;

public class OrcsAI : GameAI
{
    private readonly List<Scout> _scouts = [];
    private readonly List<Warrior> _warriors = [];
    public override void BuildStructures()
    {
        
    }
    public override void BuildUnits()
    {
        
    }
    public override void SendScouts(Vector2 position)
    {
        if (_scouts.Count > 0)
        {

        }
    }
    public override void SendWarriors(Vector2 position)
    {
        if (_warriors.Count > 5)
        {

        }
    }
}

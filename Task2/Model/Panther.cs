namespace Task2.Model;

public class Panther : Animal, IVoicable
{
    public override double Speed => throw new NotImplementedException();

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override void Stand()
    {
        throw new NotImplementedException();
    }

    public void Voice()
    {
        throw new NotImplementedException();
    }

    public string ClimbTree()
    {
        return "*Пантера залезла на дерево*";
    }
}

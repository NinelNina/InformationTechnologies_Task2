namespace Task2.Model;

public class Dog : Animal, IVoicable
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
}

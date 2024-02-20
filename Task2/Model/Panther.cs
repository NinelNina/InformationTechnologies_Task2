namespace Task2.Model;

public class Panther : Animal, IVoicalizable
{
    public event EventHandler Voice;
    public event EventHandler ClimbTree;

    public override void Move()
    {
        if (Speed < maxSpeed)
        {
            Speed += 20;
        }
    }

    public override void Stand()
    {
        if (Speed > minSpeed)
        {
            Speed -= 20;
        }
    }

    public void OnClimbTree()
    {
        ClimbTree?.Invoke(this, EventArgs.Empty);
    }

    public void OnVocalize()
    {
        Voice?.Invoke(this, EventArgs.Empty);
    }
}

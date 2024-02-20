namespace Task2.Model;

public class Dog : Animal, IVoicalizable
{
    public event EventHandler Voice;

    public override void Move()
    {
        if (Speed < maxSpeed)
        {
            Speed += 10;
        }
    }

    public void OnVocalize()
    {
        Voice?.Invoke(this, EventArgs.Empty);
    }

    public override void Stand()
    {
        if (Speed > minSpeed)
        {
            Speed -= 10;
        }
    }
}

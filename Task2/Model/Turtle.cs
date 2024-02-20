namespace Task2.Model;

public class Turtle : Animal
{
    public override void Move()
    {
        if (Speed < maxSpeed)
        {
            Speed += 5;
        }
    }

    public override void Stand()
    {
        if (Speed > minSpeed)
        {
            Speed -= 5;
        }
    }
}

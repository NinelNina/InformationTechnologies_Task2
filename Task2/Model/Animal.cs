﻿namespace Task2.Model;

public abstract class Animal
{
    public double Speed { get; set; }
    protected const double maxSpeed = 100;
    protected const double minSpeed = 0;

    public abstract void Move();
    public abstract void Stand();
}

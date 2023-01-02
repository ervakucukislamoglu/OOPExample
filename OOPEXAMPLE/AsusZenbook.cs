using System;
public class AsusZenbook : Laptop
{
    public override bool TouchScreen => true;

    public override void TurnOn()
    {
        Console.WriteLine("Turning On spesific to AsusZenbook.");
    }
}

using System;
public class MacBookAir : Laptop
{
    public override bool TouchScreen => false;

    public override void TurnOn()
    {
       Console.WriteLine("Turning On spesific to MacbookAir.");
    }
}
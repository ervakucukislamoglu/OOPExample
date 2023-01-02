using System;

namespace OOPEXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macbookAir = new MacBookAir();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();

            Console.WriteLine(macbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen);

            Console.WriteLine("Git denemesi için eklenen cw");
        }
    }






}

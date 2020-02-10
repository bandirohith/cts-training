using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter h = new Helicopter(4,4.5);
            h.fly();
            Aeroplane a = new Aeroplane(300,2.2);
            a.fly();
            Console.ReadKey();
        }
    }
}

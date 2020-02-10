using System;

namespace Inheritance
{
    class All
    {
        static void Main(string[] args)
        {
            //Movriding mov = new Movriding();
            //mov.Show();
            Bike();
            Console.ReadKey();
        }

        private static void Bike()
        {
            Bike b = new Bike();
            b.Display();
            b.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorDemo
{
    class CarDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car("BENZ","E250",74.05952959000000000000);
            Console.WriteLine( c.showCar());
            Console.ReadKey();
        }
    }
}

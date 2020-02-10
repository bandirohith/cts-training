using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bike : vehicle
    {
        public void Display()
        {
            Console.WriteLine("riding bike ");
        }
        new public void Show()
        {
            Console.WriteLine("at 160 is awesome");
        }
    }
}

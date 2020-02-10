using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Aeroplane:AirBone
    {
        int seatCapacity;
        double fuelCapacity;
        public Aeroplane(int sc,double fc)
        {
            this.fuelCapacity=fc;
            this.seatCapacity = sc;
        }
        public void fly()
        {
            Console.WriteLine("aeroplane flies");
            Console.WriteLine("fuel capacity is: {0} \n seat capacity is: {1}", seatCapacity, fuelCapacity);

        }
    }
}

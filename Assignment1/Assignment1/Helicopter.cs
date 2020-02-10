using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Helicopter:AirBone
    {
        int noOfBlades;
        double fuelCapacity;
        public Helicopter(int nob,double fc)
        {
            this.noOfBlades = nob;
            this.fuelCapacity = fc;
        }
        public void fly()
        {
            Console.WriteLine("helicopter flies");
            Console.WriteLine("fuel capacity is: {0} \n No of Blades is: {1}",noOfBlades,fuelCapacity);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ifaces
{
    class Bike
    {
         string bikeName;
         public int bikePrice;
         int bikeSpeed;
         double bikeMilage;
        public Bike() { }
        public Bike(string bikeName,int bikePrice,int bikeSpeed,double bikeMilage)
        {
            this.bikeMilage = bikeMilage;
            this.bikeName = bikeName;
            this.bikePrice = bikePrice;
            this.bikeSpeed = bikeSpeed;
        }
        public virtual  void insurance()
        {
            Console.WriteLine("insurance is not there");
        }
    }
}

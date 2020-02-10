using System;
using System.Collections.Generic;
using System.Text;

namespace Ifaces
{
    class BikeDrone:Bike,Interface1
    {
        public void bikePriceWithDiscount(int bikePrice, int percent)
        {
            int discount = (percent / 100) * bikePrice;
            bikePrice -= discount;
            Console.WriteLine("bike price is:{0}",bikePrice);
        }
        public void bikeGarageServices(int amount, int nofService)
        {
            int serviceprice = nofService * amount;
            Console.WriteLine(serviceprice);
        }
       public  void emi(int roi, int months)
        {
            int total = bikePrice;
            total += (roi / 100) * months;
            Console.WriteLine(total);
        }
        public override void insurance()
        {
            base.insurance();
            Console.WriteLine("insurance is paid now");
        }
        public static void Main(string[] args)
        {
            Bike b1 = new Bike("Rs200",120000,180,20.5);
            BikeDrone bd = new BikeDrone();
            bd.bikeGarageServices(500, 2);
            bd.bikePriceWithDiscount(b1.bikePrice,3);
            bd.emi(3,24);
            bd.insurance();
            Console.ReadKey();
        }
    }
}

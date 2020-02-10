using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class All
    {
        static void Main(string[] args)
        {
            //MethodOverloadingObj();

            //TotalSales();
            Practice s = new Practice();
            Practice s1= new Practice();



            Practice.Show();

            Console.ReadKey();

        }

        private static void TotalSales()
        {
            Sales s1 = new Sales("chocolate", 2, 10.5);


            Sales s2 = new Sales("shirt", 1, 99.50);
            Sales s3 = new Sales("pant", 3, 199.50);
            Sales s4 = new Sales("suit", 2, 299.50);

            Console.WriteLine(s2.SalesAmount());
        }

        private static void MethodOverloadingObj()
        {
            Calculate c = new Calculate();

            Console.WriteLine(c.area(10));

            Console.WriteLine(c.area(5, 5));

            Console.ReadKey();
        }
    }
}

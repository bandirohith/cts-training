using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_overloading
{
    class Program
    {

        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.a1 = 10;
            d1.a2 = 20;

            Demo d2 = new Demo();
            d2.a1 = 10;
            d2.a2 = 20;

            Demo t = d1 + d2;

            Console.WriteLine(t.a1 + " " + t.a2);
            Console.ReadKey();
        }







    }
}

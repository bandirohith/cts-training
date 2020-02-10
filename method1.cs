using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method1
{
    class Program
    {
        public static void add(int a,int b)
        {
            Console.WriteLine("The sum of A and B is"+ (a + b));
        }
        public static double Multiply(double a,double b)
        {
            return a*b;
        }

        static void Main(string[] args)
        {
            add(5, 5);
            double d= Multiply(2.5, 2.5);
            Console.WriteLine("multiply of a and b is " + d);
            Console.ReadKey();
        }
    }
}

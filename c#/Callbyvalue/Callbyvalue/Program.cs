using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callbyvalue
{
    class Program
    {
        public static void callbyvalue(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("call by value After swapping a={0}and b={1}", a, b);
        }
        public static void callbyvalue(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("call by reference After swapping a={0}and b={1}", a, b);
        }
        static void Main(string[] args)
        {
            int a =10;
            int b = 20;
            Console.WriteLine("call by value beforwe swapping a={0}and b={1}", a, b);
            callbyvalue(a, b);
            Console.WriteLine("call by value after swapping a={0}and b={1}", a, b); callbyvalue(ref a, ref b);
            Console.WriteLine("call by reference after swapping a={0}and b={1}", a, b);
           
            Console.ReadKey();
        }
    }
}

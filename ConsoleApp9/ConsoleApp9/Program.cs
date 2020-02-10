using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            c1.No1 = 200;
            c1.No2 = 300;
            Console.WriteLine( c1.Add());
            Console.WriteLine(c1.Difference());
            Console.WriteLine(c1.Multiply());
            Console.WriteLine(c1.Division());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprop
{
    class Program
    {
        public static void LambdaExp()
        {
            Func<int,int,int> Traingle =(
                a,b)=>  (a*b)/2;
            Console.WriteLine(Traingle(4,6));
        }
        public static void LambdaLinqExp()
        {
            int[] nos = { 45, 12, 13, 14 };
            var sort = nos.OrderBy(x=>x);
            Console.WriteLine(string.Join(" ",sort));
        }
        static void Main(string[] args)
        {
            LambdaExp();
            LambdaLinqExp();
            Console.ReadKey();
        }
    }
}

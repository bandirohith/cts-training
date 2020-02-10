using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgates
{
    public delegate string mydel(int a, int b);
    public delegate string mydel1(int side);
    class Program
    {
        public static string square(int side)
        {
            return Convert.ToString(side * side);
        }
        public static string add(int a,int b)
        {
            int c;
            c = a + b;
            return Convert.ToString(c);
        }

        public static string sub(int a, int b)
        {
            int c;
            c = a - b;
            return Convert.ToString(c);
        }
        static void Main(string[] args)
        {
            mydel md=new mydel(add);
            Console.WriteLine(md(10, 20));
            md = md + new mydel(sub);
            Console.WriteLine(md(2, 3));
            mydel1 md1 = new mydel1(square);
            Console.WriteLine(md1(2));
            Console.ReadKey();
        }
    }
}

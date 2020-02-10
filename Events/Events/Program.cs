using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        public static void square()
        {
            int side;
            Console.WriteLine("enter side");
            side = int.Parse(Console.ReadLine());
            Console.WriteLine(side*side);
        }
        public static void circle()
        {
            double r;
            double pi = 3.14;
            double area;
            Console.WriteLine("enter r value");
            r = int.Parse(Console.ReadLine());
            area = pi * r * r;
            Console.WriteLine(area);
        }
        static void Main(string[] args)
        {
            handler += new Deleventhandler(square);
            handler += new Deleventhandler(circle);
            handler.Invoke();
            Console.ReadKey();
        }
    }
}

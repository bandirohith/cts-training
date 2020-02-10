using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1
{
    class Program
    {
        public void method2(int age,String name)
        {
            Console.WriteLine("Hi" + name + "belated happy birthday now your age is" + age);
        }
        public static void method1(int age,String name)
        {
            Console.WriteLine("Hi" + name + "belated happy birthday now your age is" + age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Program p = new Program();
            p.method2(25,"charan");
            method1(22,"Rohith");
            Console.WriteLine("main ends");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String ename;

            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine(ename);
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("congratulations Mr/Miss {0} on your {1} bitrthday", ename, age);
            Console.ReadKey();

           
        }
    }
}

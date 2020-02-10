using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace project
{
    class Program
    {
        ArrayList a1 = new ArrayList();
        static void Main(string[] args)
        {
            int i = 0;
          
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                a1.Add();

                n = n / 2;
                i++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
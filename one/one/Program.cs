using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ArrayList a1 = new ArrayList();
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0) 
            {

                
                n = n / 2;
                i++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
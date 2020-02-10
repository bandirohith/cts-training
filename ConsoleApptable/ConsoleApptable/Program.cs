using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptable
{
    class Program
    { 
        enum cars
        {
            volvo=1,
            benz,
            ferrari=6,
            audi=19
        };
        public static void enumDemo()
        {
            Console.WriteLine((int)cars.volvo);
            Console.WriteLine((int)cars.benz);
            Console.WriteLine((int)cars.ferrari);
            Console.WriteLine((int)cars.audi);
        }
    
        public static void divide(int divisor, int n)
        {
            while (n != 0)
            {
                Console.WriteLine("division of a number:");
                int rem = divisor / n;
                n--;
                Console.WriteLine("remeinder is" + rem);

            }

        }
        public static void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("sum of a and b is:"+c);

        }
        public static void multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("sum of a and b is:" + c);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice");
            Console.WriteLine("1.divide 2.add 3.multiply 4.enum");
            string ch =Console.ReadLine();
            switch(ch)
            {
                case "1":
                    Console.WriteLine("division is");
                    divide(500, 5);
                    break;
                case "2":
                    Console.WriteLine("Addition is");
                    add(500, 5);
                    break;
                case "3":
                    Console.WriteLine("Multiplication is");
                    multiply(500, 5);
                    break;
                case "4":
                    Console.WriteLine("enumeration  is");
                    enumDemo();
                    break;
            }

            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            if (n < 100)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}*{1}={2}", n, i, n * i);
                }
            }
            else if (n >= 100)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}*{1}={2}", n, i, n * i);
                }
            }
            else
                Console.WriteLine("You entered a negitive number");

            Console.ReadKey();
        }
         
        

    }
}
   

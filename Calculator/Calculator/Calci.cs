using System;

namespace Calculator
{
    class Calci
    {
        int choice;
        int x, y;
        public Calci() { }

        public Calci(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
        public int add()
        {
            return x + y;
        }
        public int sub()
        {
            return x - y;
        }
        public int Mul()
        {
            return x * y;
        }
        public double Div()
        {
            return x / y;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter X and Y values");
            
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Calci c1 = new Calci(x, y);
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
           switch(choice)
            {
                case 0:Console.WriteLine(c1.add());
                    break;
                case 1: Console.WriteLine(c1.add());
                    break;
                case 2:Console.WriteLine(c1.Mul());
                    break;
                case 3: Console.WriteLine(c1.Div());
                    break;

            }
            Console.ReadKey();
        }
    }
}

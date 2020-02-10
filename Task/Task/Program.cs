using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
           
            Console.WriteLine(c1.values(new string[] { "rohith", "naidu", "bandi" }));
            Console.WriteLine(c1.Name("rohith", " bandi"));
            c1.Method1("ROHITH");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            method1(20,"rohith");
            Console.WriteLine(method1(20, "rohith"));
            Console.ReadKey();
        }
        public static string method1(int age,string name)
        {
            string s="hi" + name + "happy birthday now your age is" + age;
            return s;
            

        }
    }
}

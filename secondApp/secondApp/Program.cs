using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondApp
{
    class Program
    {
        public static string method1(int a,string name)
        {
            return String.Format("congratulations mr/mrs{0} on your {1} birthday", name, a);
        }
        static void Main(string[] args)
        {
           Console.WriteLine( method1(22, "rohith"));
            Console.ReadKey();
        }
    }
}

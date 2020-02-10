using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("bandi");
            a1.Add("rohith");
            foreach( var a in a1)
            {
                Console.WriteLine(a);
                
            }
            string[] r = new string[] { "cat", "bat" };
            a1.SetRange(0, r);
            foreach(var a in a1)
            {
                Console.Write(a);
            }
           
            Console.ReadKey();

        }
    }
}

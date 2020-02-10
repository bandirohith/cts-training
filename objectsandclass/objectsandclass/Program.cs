using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectsandclass
{
    public class Program
    {
        public int id;
        public string name;
    }
    public class nextProgram 
    {
      public  static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.id = 10;
            p1.name = "rohith";
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.id);
        }
    }
    
}

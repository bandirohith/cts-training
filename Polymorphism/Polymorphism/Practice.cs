using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Practice
    {
        int no = 0;
        static int count = 0;
        public Practice()
        {
            no++;
            count++;
            Console.WriteLine("no{0} \n count {1}", no, count);

        }
        public static void Show()
        {
            count++;
            Console.WriteLine("from static show method and count is {0}", count);
        }
    }
}

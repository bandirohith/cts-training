using System;

namespace Task1
{
    class Program
    {
       public int[] Reverse(int[] value)
        {
            int index = value.Length - 1;
            for(int i=0;i<value.Length;i++)
            {
                

            }
            //for(int i=value.Length-1;i>=0;i--)
            //{
            //    Console.Write(value[i]);
            //}
           return value;
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Reverse(new int[] { 1, 2, 3, 4 });
            Console.ReadKey();
        }
    }
}

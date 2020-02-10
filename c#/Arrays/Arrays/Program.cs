using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {/*
        public static double Average(int [] arr,int subjects)
        {
            double sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
              sum += arr[i];
                
            }
            return sum/subjects;
        }
        public void show(params int[] val)
        {
            Console.WriteLine("\nIndex position of 2 is " + Array.IndexOf(val, 2));
            for (int i = 0; i <= val.Length; i++)
            {
                Console.WriteLine(val[i]);
                
            //}
           

        }*/
        static void main(string[] args) // string type parameters  
        {
            // command line arguments  
            console.writeline("argument length: " + args.length);
            console.writeline("supplied arguments are:");
            foreach (object obj in args)
            {
                console.writeline(obj);
            }
        }
        /*
        public static void Main()
        {
            int[,] arr = new int[2,5] { { 32, 44, 55, 77, 88 }, { 11, 22, 33, 44, 55 } };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    Console.Write(arr[i,j]+ " \t");
                  
                }
                Console.WriteLine();
                
            }
            Program p1 = new Program();
            p1.show(2, 3, 4, 5, 6, 7, 8);

           
            Console.ReadKey();
          /*   
            Console.WriteLine(Average(arr, arr.Length));
            Console.ReadKey();*/
    }
}
}

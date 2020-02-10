using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[] { 85, 89, 54, 44, 37 };
          
            Array.Sort(arr);
            int[] arr1 = new int[] { 89, 54, 37, 85, 66 };
            Array.Sort(arr1);
            
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr1[i]);
                 if (arr[i] != arr1[i])
                {
                    sum += arr[i] + arr1[i];
                }
            }
        }
    }
}

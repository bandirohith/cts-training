using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a12b13";
            char[] c=a.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if(char.IsDigit(c[i]))
                {
                    for(int j=0;j<c[i];j++)
                    {
                        
                    }
                    
                }
                
            }
            Console.ReadKey();
        }
        
    }
}

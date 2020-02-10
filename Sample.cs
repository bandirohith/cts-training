using System;

namespace FirstApp
{
	public class Sample
	{
		public static void Main(String[] arg)
		{
			  float f1,f2;
            		  
			  double d;
           		  Console.WriteLine("enter f1 number");
         		   f1 =float.Parse(Console.ReadLine());
         		   
          		   Console.WriteLine("enter number f2");
           		   f2 = float.Parse(Console.ReadLine());
			   d=f1*f2 ;
         		   Console.WriteLine(" product of f1 and f2 is"+d );
           		  Console.ReadKey();

            
		}
	
	}
}
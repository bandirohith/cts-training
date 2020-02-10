using System;

namespace Exceptions
{
    class Program
    {
       static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July", "September", "October", "November", "December"};

            int num =0;
            Console.WriteLine("Enter numerator");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter denominator");
            int denominator = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.Day);
            Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
            Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
            Console.WriteLine("Today's time: {0}", now.TimeOfDay);
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);

            try
            {
                if (num <= 0)
                {
                    int rem = numerator / denominator;
                    Console.WriteLine(rem);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("cannot divide with zero");
            }
            finally
            {
                Console.WriteLine("it will execute whether there is an exception or not");
            }
            Console.ReadKey();
        }
    }
}

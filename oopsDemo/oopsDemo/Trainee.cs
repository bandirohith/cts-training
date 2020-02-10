using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsDemo
{
    class Trainee
    {
        static void Main(string[] args)
        {
            
            /* get1obj();
             examobj();
             get2obj();*/

            //Automaticprop();

            // property();

            //TimeObjMethod();

            Scale sc = new Scale();
            sc.Inch = 15;
            Console.WriteLine("Inches is{0}", sc.Inch);
            sc.showcent();

            Console.ReadKey();
        }

        private static void Automaticprop()
        {
            AutomaticProperties ap = new AutomaticProperties { Id = 1, ProductName = "Benz", Price = 50.00 };
            Console.WriteLine("product id is:{0}\n product nameis:{1}\n product price is:{2}\n ", ap.Id, ap.ProductName, ap.Price);
        }

        /*  private static void property()
          {
              properties p = new properties("rohith", "bandi");

              p.IdNo = 844919;
              p.Course = ".net";
              p.Joindate = DateTime.Parse("11/11/1997");
              Console.WriteLine("name is {0}\n Id is {1} \n course is {2} \n joindate is {3}", p.Name, p.IdNo, p.Course, p.Joindate);
          }*/
        private static void TimeObjMethod()
        {
            Timeperiod tp = new Timeperiod();
            tp.Hours = 24;
            Console.WriteLine("hours:{0}", tp.Hours);
            tp.showseconds();
        }

        /* private static void examobj()
         {
             Exam e1 = new Exam();
             e1.ExamData("R14", "Gec", "M1", "abdul", 844919);
             e1.showData();
         }

         private static void get2obj()
         {
             Program p1 = new Program();
             p1.GetData("saravanan", "844789", "perungudi", 22);
             p1.display();
         }

         private static void get1obj()
         {
             Program p = new Program();
             p.GetData("Rohith", "844919", "Kandanchavidi", 22);
             p.display();

         }*/
    }
}

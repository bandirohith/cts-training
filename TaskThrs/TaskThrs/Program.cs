using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThrs
{
    class Program
    {

        static void Main(string[] args)
        {
            Student s1 = new Student();
            List<Student> l1 = new List<Student>
            {

                new Student{Sid=40,Sname="rohith",Sbranch="cse" },
                new Student{Sid=20,Sname="sarava",Sbranch="cse" },
                new Student{Sid=30,Sname="vinod",Sbranch="cse" }
            };
            var li= s1.ListDemo(l1);
            foreach(var c in li)
            {
                Console.WriteLine("{0}\t{1}\t{2}",c.Sid,c.Sname,c.Sbranch);
            }
            Console.ReadKey();
        }   
    }

}
    


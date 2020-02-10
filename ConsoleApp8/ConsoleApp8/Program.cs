using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public int id;
        public string name;
        public double fee;
        public void values()
        {
            Console.WriteLine("enter couse details");
            Console.WriteLine("enter couse id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter couse name");
             name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter couse fee details");
             fee = double.Parse(Console.ReadLine());
        }
        //public void show()
        //{
        //    Console.WriteLine("course id:{0}\n course name:{1}\n course fee is:{2}",id,name,fee);
        //}
        static void Main(string[] args)
        {
            List<Course> cl = new List<Course>();

            Program p = new Program();
            p.values();

            //cl.Add(new Course { Cid =10, Cname =" rohith", Cfee =100.30 });
            //cl.Add(new Course { Cid = 100, Cname = "sarava", Cfee = 23.33 });
            //cl.Add(new Course { Cid = 12, Cname = "vinod", Cfee = 33.33 });
            //cl.Add(new Course { Cid = 15, Cname = "momo", Cfee = 23.33 });
            cl.Add(new Course { Cid = p.id, Cname = p.name, Cfee = p.fee });
            
            cl.Add(new Course { Cid = p.id, Cname = p.name, Cfee = p.fee });
           // p.show();
            cl.Add(new Course { Cid = p.id, Cname = p.name, Cfee = p.fee });
            cl.Add(new Course { Cid = p.id, Cname = p.name, Cfee = p.fee });

           var query = from a in cl select a;
            foreach(var a in cl)
            {
                Console.WriteLine("course id:{0}\n course name:{1}\n course fee is:{2}", a.Cid, a.Cname, a.Cfee);
            }


           
            Console.ReadKey();
        }
    }
}

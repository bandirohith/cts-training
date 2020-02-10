using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsDemo
{
    class Program
    {
        string name, id, address;
         int age;

        public void GetData(string nm, string id, string adr, int age)
        {
            name = nm;
            this.id = id;
            address = adr;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("trainee name:" + name +"\n" + "trainee id:" + this.id +"\n" + "trainee adress:" + address +"\n" + "tarinee age:" + this.age);
        }
        
    }
}

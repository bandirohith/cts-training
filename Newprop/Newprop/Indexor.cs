using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newprop
{
    class Indexor<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        class product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
        public static void Main(string[] args)
        {
            Indexor<product> g = new Indexor<product>();
            product p1 = new product();
            p1.Id = 1;
            p1.Name = "pepsi";
            p1.Price = 15.50;
            g[0]= p1;
            
            
            Console.WriteLine(g[0].Id);
            Console.ReadKey();
        }
    }
}
